using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using ModuDevCore.PathweaveUIX;
using ModuDevCore.PathweaveUIX.Data;
using ModuDevCore.PathweaveUIX.Runtime.Events;

namespace ModuDevCore.PathweaveUIX.Editor  {
    [CustomEditor(typeof(PathweaveUIX))]
    public class PathweaveUIXEditor : UnityEditor.Editor
    {
        private bool expandedDrawList = false;

        private PathweaveUIX pathweaveUIX;
        private PathweavePage current;
        private Texture2D banner;
        private Texture2D bannerBlured;

        public override void OnInspectorGUI()
        {
            pathweaveUIX = target as PathweaveUIX;

            if (pathweaveUIX == null)
                return;

            if (serializedObject == null)
                return;

            current = pathweaveUIX.CurrentPage;

            serializedObject.Update();
            DrawBanner();

            EditorGUILayout.Space(5);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("autoApplyAnyPrefabOverrides"));

            expandedDrawList = EditorGUILayout.Foldout(
                expandedDrawList,
                $"UI List ({pathweaveUIX.pages.Count})",
                true
            );

            DrawUIList();
            DrawNavigationMenu();
            DrawDebugPanel();

            serializedObject.ApplyModifiedProperties();
        }
        void DrawDebugPanel()
        {
            EditorGUILayout.Space(8);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            GUIStyle header = new GUIStyle(EditorStyles.boldLabel)
            {
                normal = { textColor = new Color(0.4f, 0.9f, 1f) }
            };

            EditorGUILayout.LabelField("Runtime Debug", header);

            EditorGUILayout.Space(4);

            // ─────────────────────────────
            // HASH ROUTE
            // ─────────────────────────────
            EditorGUILayout.LabelField(
                "Hash Route",
                string.IsNullOrEmpty(pathweaveUIX.FullPagePath)
                    ? "None"
                    : pathweaveUIX.FullPagePath
            );
            EditorGUILayout.LabelField(
                "Route Data",
                string.IsNullOrEmpty(pathweaveUIX.RouteData)
                    ? "None"
                    : pathweaveUIX.RouteData
            );
            // ─────────────────────────────
            // CURRENT PAGE
            // ─────────────────────────────
            EditorGUILayout.LabelField(
                "Current Page",
                pathweaveUIX.CurrentPage != null
                    ? pathweaveUIX.CurrentPage.name
                    : "None"
            );

            // ─────────────────────────────
            // PAGE COUNT
            // ─────────────────────────────
            EditorGUILayout.LabelField(
                "Pages",
                pathweaveUIX.pages != null
                    ? pathweaveUIX.pages.Count.ToString()
                    : "0"
            );

            EditorGUILayout.Space(4);

            // ─────────────────────────────
            // ANIMATION STATE (если есть)
            // ─────────────────────────────
            if (pathweaveUIX.CurrentPage != null)
            {
                var anim = pathweaveUIX.CurrentPage.animations;

                EditorGUILayout.LabelField("Animations");

                EditorGUILayout.LabelField("→ Open", anim.GoRightOpenStateName);
                EditorGUILayout.LabelField("← Open", anim.GoLeftOpenStateName);
                EditorGUILayout.LabelField("→ Close", anim.GoRightCloseStateName);
                EditorGUILayout.LabelField("← Close", anim.GoLeftCloseStateName);
            }

            EditorGUILayout.Space(4);

            // ─────────────────────────────
            // LIVE STATE INDICATOR
            // ─────────────────────────────
            GUIStyle stateStyle = new GUIStyle(EditorStyles.miniLabel)
            {
                normal = { textColor = Color.green }
            };

            EditorGUILayout.LabelField("Status", stateStyle);

            string status =
                pathweaveUIX.CurrentPage == null
                    ? "Idle"
                    : "Running UI Flow";

            EditorGUILayout.LabelField(status);

            EditorGUILayout.EndVertical();
        }
        void DrawBanner()
        {
            if (banner == null || bannerBlured == null){
                MonoScript script = MonoScript.FromScriptableObject(this);

                string scriptPath = AssetDatabase.GetAssetPath(script);
                string folder = System.IO.Path.GetDirectoryName(scriptPath);

                banner = AssetDatabase.LoadAssetAtPath<Texture2D>(AssetDatabase.GUIDToAssetPath("b9d300620fa0c0f0cb9d2da55172a8cc"));
                bannerBlured = AssetDatabase.LoadAssetAtPath<Texture2D>(AssetDatabase.GUIDToAssetPath("35069517513f7a7c4a20b84202fbf30d"));
            }

            GUILayout.Space(4);

            float width = EditorGUIUtility.currentViewWidth - 24f;
            float aspect = (float)banner.height / banner.width;
            float height = width * aspect;

            Rect rect = GUILayoutUtility.GetRect(width/2, height/2);

            // EditorGUI.DrawRect(new Rect(rect) { width = width }, new Color(0.796f, 0.796f, 0.796f, 0.5f));
            GUI.DrawTexture(
                new Rect(rect) { width = width },
                bannerBlured,
                ScaleMode.ScaleAndCrop,
                true
            );           
             GUI.DrawTexture(
                new Rect(rect) { width = banner.width },
                banner,
                ScaleMode.ScaleToFit,
                true
            );

            EditorGUIUtility.AddCursorRect(rect, MouseCursor.Link);

            GUILayout.Space(2);
        }
        SerializedProperty SafeFind(string name)
        {
            if (serializedObject == null) return null;
            return serializedObject.FindProperty(name);
        }
        void DrawActions(PathweavePage ui)
        {
            ui.showActions = EditorGUILayout.Foldout(ui.showActions, "Actions", true);

            if (!ui.showActions)
                return;

            EditorGUILayout.LabelField("Actions", EditorStyles.boldLabel);

            SerializedProperty pagesProp =
                serializedObject.FindProperty("pages");
            int pageIndex = pathweaveUIX.pages.IndexOf(ui);

            if (pagesProp == null || pageIndex < 0 || pageIndex >= pagesProp.arraySize)
                return;

            SerializedProperty pageProp =
                pagesProp.GetArrayElementAtIndex(pageIndex);

            SerializedProperty actionsProp =
                pageProp.FindPropertyRelative("actions");

            if (actionsProp == null)
                return;

            for (int i = 0; i < actionsProp.arraySize; i++)
            {
                SerializedProperty actionProp =
                    actionsProp.GetArrayElementAtIndex(i);

                SerializedProperty nameProp =
                    actionProp.FindPropertyRelative("name");

                SerializedProperty eventProp =
                    actionProp.FindPropertyRelative("uiEvent");

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                EditorGUILayout.BeginHorizontal();

                EditorGUILayout.PropertyField(nameProp, GUIContent.none);

                Color prev = GUI.backgroundColor;
                GUI.backgroundColor = new Color(1f, 0.3f, 0.3f);

                if (GUILayout.Button("X", GUILayout.Width(25)))
                {
                    actionsProp.DeleteArrayElementAtIndex(i);
                    GUI.backgroundColor = prev;
                    EditorGUILayout.EndHorizontal();
                    EditorGUILayout.EndVertical();
                    break;
                }

                GUI.backgroundColor = prev;

                EditorGUILayout.EndHorizontal();

                if (eventProp != null)
                    EditorGUILayout.PropertyField(eventProp, new GUIContent("Event"), true);

                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.Space(4);

            GUI.backgroundColor = new Color(0.35f, 0.85f, 0.45f);

            if (GUILayout.Button("Add Action"))
            {
                ui.actions.Add(new PathweavePage.PathweaveAction()
                {
                    name = "New Action",
                    uiEvent = new PathweaveEvent()
                });
            }

            GUI.backgroundColor = Color.white;
        }

        void DrawAnimationsSection(PathweavePage ui)
        {
            ui.showAnimations = EditorGUILayout.Foldout(ui.showAnimations, "Animations", true);

            if (!ui.showAnimations)
                return;

            EditorGUI.indentLevel++;

            ui.animations.GoRightOpenStateName =
                EditorGUILayout.TextField("→ Open", ui.animations.GoRightOpenStateName);

            ui.animations.GoLeftOpenStateName =
                EditorGUILayout.TextField("← Open", ui.animations.GoLeftOpenStateName);

            ui.animations.GoRightCloseStateName =
                EditorGUILayout.TextField("→ Close", ui.animations.GoRightCloseStateName);

            ui.animations.GoLeftCloseStateName =
                EditorGUILayout.TextField("← Close", ui.animations.GoLeftCloseStateName);

            ui.animations.StaticOpenStateName =
                EditorGUILayout.TextField("Static Open", ui.animations.StaticOpenStateName);

            ui.animations.StaticCloseStateName =
                EditorGUILayout.TextField("Static Close", ui.animations.StaticCloseStateName);

            EditorGUI.indentLevel--;
        }

        void DrawNavigationMenu()
        {
            EditorGUILayout.Space(5);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            GUIStyle headerStyle = new GUIStyle(EditorStyles.boldLabel)
            {
                alignment = TextAnchor.MiddleLeft,
                fontSize = 12
            };

            EditorGUILayout.LabelField("Navigation", headerStyle);

            EditorGUI.BeginChangeCheck();

            pathweaveUIX.FullPagePath = EditorGUILayout.TextField("Path", pathweaveUIX.FullPagePath);
            current = pathweaveUIX.CurrentPage;
            EditorGUILayout.Space(4);

            string[] names = pathweaveUIX.pages.Select(x => x.name).ToArray();
            string[] popupOptions = new[] { "None" }.Concat(names).ToArray();

            int index = current == null
                ? 0
                : Array.IndexOf(names, current.name) + 1;

            int newIndex = EditorGUILayout.Popup("Current UI", index, popupOptions);

            if (newIndex == 0)
            {
                current = null;
            }
            else if (newIndex - 1 >= 0 && newIndex - 1 < pathweaveUIX.pages.Count)
            {
                current = pathweaveUIX.pages[newIndex - 1];
            }

            if (EditorGUI.EndChangeCheck())
            {
                pathweaveUIX.UpdatePage(current, false);
            }

            EditorGUILayout.Space(6);

            EditorGUILayout.BeginHorizontal();

            GUI.backgroundColor = new Color(0.3f, 0.8f, 0.4f);
            if (GUILayout.Button("Next", GUILayout.Height(22)))
                pathweaveUIX.NavigateWithHash("_choose_");

            GUI.backgroundColor = new Color(0.3f, 0.6f, 0.9f);
            if (GUILayout.Button("Back", GUILayout.Height(22)))
                pathweaveUIX.NavigateBackWithHash();

            GUI.backgroundColor = new Color(0.8f, 0.3f, 0.3f);
            if (GUILayout.Button("Clear", GUILayout.Height(22)))
                pathweaveUIX.ClearHash();

            GUI.backgroundColor = Color.white;

            EditorGUILayout.EndHorizontal();

            EditorGUILayout.Space(4);

            if (GUILayout.Button("Apply Prefabs", GUILayout.Height(22)))
                pathweaveUIX.ApplyPrefabs();

            EditorGUILayout.EndVertical();
        }

        void DrawUIList()
        {
            EditorGUILayout.Space(5);

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.Space(5);

            if (current != null)
            {
                int index = pathweaveUIX.pages.IndexOf(current);

                if (index > 0)
                {
                    pathweaveUIX.pages.RemoveAt(index);
                    pathweaveUIX.pages.Insert(0, current);
                }
            }

            for (int i = 0; i < pathweaveUIX.pages.Count; i++)
            {
                PathweavePage ui = pathweaveUIX.pages[i];
                bool isCurrent = pathweaveUIX.CurrentPage == ui;

                if (isCurrent)
                    ui.isExpanded = true;
                else if (!expandedDrawList)
                    continue;

                EditorGUILayout.BeginVertical(EditorStyles.helpBox);

                EditorGUILayout.BeginHorizontal();

                if (!isCurrent)
                {
                    ui.isExpanded = EditorGUILayout.Foldout(
                        ui.isExpanded,
                        ui.descriptor,
                        true
                    );
                }
                else
                {
                    GUIStyle currentStyle = new GUIStyle(EditorStyles.boldLabel)
                    {
                        normal =
                        {
                            textColor = new Color(0.3f, 1f, 0.6f)
                        },
                        fontStyle = FontStyle.Bold
                    };

                    EditorGUILayout.LabelField($"▶ {ui.descriptor} (Current)", currentStyle);
                }

                Color prev = GUI.backgroundColor;

                if (isCurrent)
                {
                    if (GUILayout.Button("<", GUILayout.Width(25)))
                    {
                        pathweaveUIX.CurrentPage.isExpanded = false;
                        pathweaveUIX.NavigateBackWithHash();
                        break;
                    }
                }
                else
                {
                    if (GUILayout.Button(">", GUILayout.Width(25)))
                    {
                        if(pathweaveUIX.CurrentPage != null)
                            pathweaveUIX.CurrentPage.isExpanded = false;
                        pathweaveUIX.NavigateWithHash(ui.name);
                        break;
                    }

                    GUI.backgroundColor = new Color(0.35f, 0.85f, 0.45f);

                    if (GUILayout.Button("S", GUILayout.Width(25)))
                    {
                        if(pathweaveUIX.CurrentPage != null)
                            pathweaveUIX.CurrentPage.isExpanded = false;
                        pathweaveUIX.SetPage(ui.name);
                        break;
                    }
                }

                GUI.backgroundColor = new Color(1f, 0.3f, 0.3f);

                if (GUILayout.Button("X", GUILayout.Width(25)))
                {
                    if (EditorUtility.DisplayDialog(
                            "Delete UI",
                            $"Are you sure you want to delete '{ui.name}'?",
                            "Delete",
                            "Cancel"))
                    {
                        EditorApplication.delayCall += () =>
                        {
                            pathweaveUIX.pages.RemoveAt(i);
                        };
                    }
                    break;
                }

                GUI.backgroundColor = prev;

                Texture2D thumb = ui.prefab != null
                    ? AssetPreview.GetAssetPreview(ui.prefab)
                    : null;

                if (thumb == null && ui.prefab != null)
                {
                    thumb = AssetPreview.GetMiniThumbnail(ui.prefab);
                }

                GUILayout.Label(thumb, GUILayout.Width(25), GUILayout.Height(25));

                EditorGUILayout.EndHorizontal();

                if (ui.isExpanded)
                {
                    EditorGUI.indentLevel++;

                    ui.name = EditorGUILayout.TextField("Name", ui.name);

                    ui.prefab = (GameObject)EditorGUILayout.ObjectField(
                        "Prefab",
                        ui.prefab,
                        typeof(GameObject),
                        false
                    );

                    GUI.enabled = false;

                    ui.view = (GameObject)EditorGUILayout.ObjectField(
                        "View",
                        ui.view,
                        typeof(GameObject),
                        true
                    );

                    GUI.enabled = true;

                    EditorGUILayout.Space(3);
                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    DrawAnimationsSection(ui);
                    EditorGUILayout.EndVertical();

                    EditorGUILayout.Space(5);
                    EditorGUILayout.BeginVertical(EditorStyles.helpBox);
                    DrawActions(ui);
                    EditorGUILayout.EndVertical();

                    EditorGUI.indentLevel--;
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.Space(3);
            }

            if (!expandedDrawList)
            {
                GUIStyle hiddenStyle = new GUIStyle(EditorStyles.miniLabel)
                {
                    normal =
                    {
                        textColor = new Color(1f, 1f, 1f, 0.5f)
                    },
                    alignment = TextAnchor.MiddleLeft
                };

                if (GUILayout.Button(
                    $"{pathweaveUIX.pages.Count} elements hidden ( {string.Join(", ", pathweaveUIX.pages.Where(x => x.name != "" && x.name != null && x != current).Select(x => x.name))} )",
                    hiddenStyle,
                    GUILayout.ExpandWidth(true)
                ))
                {
                    expandedDrawList = true;
                }
            }

            if (GUILayout.Button("Add UI"))
            {
                string baseName = "NewUI";
                string newName = baseName;
                int index = 1;

                var list = pathweaveUIX.pages;

                while (list.Any(x => x.name == newName))
                {
                    newName = baseName + index;
                    index++;
                }

                pathweaveUIX.pages.Add(new PathweavePage()
                {
                    name = newName,
                    animations = new PathweavePage.TransitionAnimations()
                });
            }
            EditorGUILayout.EndVertical();
        }
    }
}