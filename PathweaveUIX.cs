using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditor.Callbacks;
#endif


namespace ModuDevCore.PathweaveUIX  {
    using Data;
    using Runtime.Animation;

    [ExecuteAlways]
    public class PathweaveUIX : MonoBehaviour
    {
        public List<PathweavePage> pages = new List<PathweavePage>();
        [SerializeField] private string _PagePath = "";

        public string RouteData
        {
            get { return ReadHashData(_PagePath); }
            set
            {
                var newValue = value ?? "";

                if (ReadHashData(_PagePath) == newValue)
                    return;

                ClearHash();
                
                PagePath = HashDataCombine(PagePath, newValue);

                if (CurrentPage != null && CurrentPage.view != null)
                {
                    CurrentPage.view.SendMessage(
                        "OnRouteDataChange",
                        newValue,
                        SendMessageOptions.DontRequireReceiver
                    );
                }
            }
        }

        public bool autoApplyAnyPrefabOverrides = false;
        private Coroutine autoApplyOverridesCoroutine;

        public string LastPageFullPath { get; private set; }
        public string FullPagePath
        {
            get { return _PagePath; }
            set
            {
                LastPageFullPath = FullPagePath;
                _PagePath = value;
            }
        }

        public string LastPagePath => LastPageFullPath?.Replace("#" + RouteData, "");
        public string PagePath
        {
            get { return FullPagePath.Replace("#" + RouteData, ""); }
            set { FullPagePath = HashDataCombine(value, RouteData); }
        }

        public List<string> LastPageListPath => LastPagePath?.Split("/")?.ToList();
        public List<string> PagePathSegments
        {
            get { return PagePath.Split("/").ToList(); }
            set { PagePath = string.Join("/", value); }
        }

        public PathweavePage LastPage => LastPageListPath == null || pages == null || pages.Count == 0 ? null : pages.Find(ui => ui.name == LastPageListPath.Last());

        public PathweavePage CurrentPage
        {
            get => pages == null || pages.Count == 0 ? null : pages.Find(ui => ui.name == PagePathSegments.Last() && ui.name != "");
            set
            {
                List<string> _PagePathSegments = PagePathSegments;
                if (value == null)
                    _PagePathSegments[_PagePathSegments.Count - 1] = "";
                else
                    _PagePathSegments[_PagePathSegments.Count - 1] = value.name;

                PagePathSegments = _PagePathSegments;
            }
        }

        private static PathweaveUIX _instance = null;
        public static PathweaveUIX Instance
        {
            get
            {
                if (_instance == null) _instance = FindAnyObjectByType<PathweaveUIX>();
                return _instance;
            }
            set { _instance = value; }
        }

        private bool _isAnimating = false;
        public bool IsAnimating
        {
            get { return _isAnimating; }
            set { _isAnimating = value; }
        }

        void SwitchUI(PathweavePage uiInfo, bool active, string animation = "", Action onReadyToChangeCallback = null)
        {
            if (uiInfo == null)
            {
                onReadyToChangeCallback?.Invoke();
                IsAnimating = false;
                return;
            }

            IsAnimating = true;

            if (!Application.isPlaying)
            {
                if (active)
                {
                    if (uiInfo.view == null)
                    {
        #if UNITY_EDITOR
                        uiInfo.view = (GameObject)PrefabUtility.InstantiatePrefab(uiInfo.prefab, transform);
        #else
                        uiInfo.view = Instantiate(uiInfo.prefab, transform);
        #endif
                        uiInfo.view.name = $"View ({uiInfo.prefab.name})";
                    }
                }
                else
                {
                    if (Application.isPlaying)
                        Destroy(uiInfo.view);
                    else
                        DestroyImmediate(uiInfo.view);
                }

                onReadyToChangeCallback?.Invoke();
                IsAnimating = false;
                return;
            }

            string stateName = animation == "GoRightOpen" ? uiInfo.animations.GoRightOpenStateName :
                               animation == "GoLeftOpen" ? uiInfo.animations.GoLeftOpenStateName :
                               animation == "GoRightClose" ? uiInfo.animations.GoRightCloseStateName :
                               animation == "GoLeftClose" ? uiInfo.animations.GoLeftCloseStateName : "";

            if (string.IsNullOrEmpty(stateName))
            {
                if (active)
                {
                    if (uiInfo.view == null)
                    {
        #if UNITY_EDITOR
                        uiInfo.view = (GameObject)PrefabUtility.InstantiatePrefab(uiInfo.prefab, transform);
        #else
                        uiInfo.view = Instantiate(uiInfo.prefab, transform);
        #endif
                        uiInfo.view.name = $"View ({uiInfo.prefab.name})";
                    }
                }
                else
                {
                    if (Application.isPlaying)
                        Destroy(uiInfo.view);
                    else
                        DestroyImmediate(uiInfo.view);
                }

                onReadyToChangeCallback?.Invoke();
                IsAnimating = false;
                return;
            }

            if (uiInfo.view == null)
            {
        #if UNITY_EDITOR
                uiInfo.view = (GameObject)PrefabUtility.InstantiatePrefab(uiInfo.prefab, transform);
        #else
                uiInfo.view = Instantiate(uiInfo.prefab, transform);
        #endif
                uiInfo.view.name = $"View ({uiInfo.prefab.name})";
            }

            PathweaveAnimatorEvents uiSysEvents = uiInfo.view != null ? uiInfo.view.GetComponent<PathweaveAnimatorEvents>() : null;

            if (uiSysEvents == null || uiSysEvents.animator == null)
            {
                onReadyToChangeCallback?.Invoke();
                IsAnimating = false;
                return;
            }

            uiSysEvents.ReadyToChangeCallback = delegate
            {
                if (!active)
                {
                    if (Application.isPlaying)
                        Destroy(uiInfo.view);
                    else
                        DestroyImmediate(uiInfo.view);
                }

                onReadyToChangeCallback?.Invoke();
                IsAnimating = false;
            };

            uiSysEvents.animator.Play(stateName);
        }

        string ReadHashData(string path) => Regex.Replace(path, "^(?!.*#).*$|^(.*)#", string.Empty);
        string HashDataCombine(string path, string RouteData) => RouteData == "" ? path : path + "#" + RouteData;

    #if UNITY_EDITOR
        public void ApplyPrefabs()
        {
            var snapshot = pages.ToArray(); // bug fix.

            foreach (PathweavePage ui in snapshot)
            {
                if (ui.view == null) continue;

                if (!PrefabUtility.HasPrefabInstanceAnyOverrides(ui.view, false)) continue;

                PrefabUtility.ApplyPrefabInstance(ui.view, InteractionMode.UserAction);

                EditorUtility.SetDirty(ui.view);
            }
        }
    #endif

        void Update()
        {
            var raycaster = GetComponent<GraphicRaycaster>();

            if (_isAnimating && !Application.isPlaying)
                _isAnimating = false;

            if (raycaster != null)
                raycaster.enabled = !_isAnimating;

            Canvas canvas = GetComponent<Canvas>();
            if (canvas != null)
                canvas.worldCamera = Camera.main;
        }
        
        void Awake() {
            IsAnimating = false;
        }

        public void UpdatePage(PathweavePage _new, bool animating = true)
        {
    #if UNITY_EDITOR
            ApplyPrefabs();
            EditorUtility.SetDirty(this);
    #endif
            if (_new == LastPage && _new != null) return;

            foreach (PathweavePage uiInfo in pages)
            {
                if (uiInfo != LastPage && uiInfo != CurrentPage)
                {
                    if (Application.isPlaying)
                        Destroy(uiInfo.view);
                    else
                        DestroyImmediate(uiInfo.view);

                    uiInfo.view = null;
                }
            }

            if (_new == null)
            {
                if (LastPage != null)
                    SwitchUI(LastPage, false,
                        animating ? (LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count < PagePathSegments.Count ? "GoLeftClose" :
                                     LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count > PagePathSegments.Count ? "GoRightClose" : "") : "",
                        delegate { IsAnimating = false; });

                return;
            }

            SwitchUI(_new, true,
                LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count < PagePathSegments.Count ? "GoLeftOpen" :
                LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count > PagePathSegments.Count ? "GoRightOpen" : "",
                delegate
                {
                    if (LastPage != null)
                        SwitchUI(LastPage, false,
                            animating ? (LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count < PagePathSegments.Count ? "GoLeftClose" :
                                         LastPageListPath != null && PagePathSegments != null && LastPageListPath.Count > PagePathSegments.Count ? "GoRightClose" : "") : "",
                            delegate { IsAnimating = false; });
                });

            if (CurrentPage != null && CurrentPage.view != null)
                CurrentPage.view.SendMessage("UIUpdate", SendMessageOptions.DontRequireReceiver);
        }

        public void SetPage(string uiName)
        {
            PagePath = uiName;
            UpdatePage(CurrentPage, false);
        }

        public void NavigateBack() => NavigateBack(false);
        public void NavigateBackWithHash() => NavigateBack(true);

        public void NavigateBack(bool saveHash)
        {
            List<string> _PagePathSegments = PagePathSegments;
            if (_PagePathSegments == null || _PagePathSegments.Count == 0) return;

            _PagePathSegments.RemoveAt(_PagePathSegments.Count - 1);
            PagePathSegments = _PagePathSegments;

            if (!saveHash) ClearHash();

            UpdatePage(CurrentPage);
        }

        public void Navigate(string path) => Navigate(path, false);
        public void NavigateWithHash(string path) => Navigate(path, true);

        public void Navigate(string path, bool saveHash)
        {
            if (string.IsNullOrEmpty(path))
                return;

            if (!saveHash) ClearHash();

            List<string> segments = PagePathSegments ?? new List<string>();

            segments.AddRange(path.Split("/"));

            PagePathSegments = segments;

            UpdatePage(CurrentPage);
        }

        public void ClearHash() => FullPagePath = PagePath;
    }
}