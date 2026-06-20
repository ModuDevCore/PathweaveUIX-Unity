using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditor.Callbacks;
#endif

using ModuDevCore.PathweaveUIX.Runtime.Events;

namespace ModuDevCore.PathweaveUIX.Data {
    [Serializable]
    public class PathweavePage : ISerializationCallbackReceiver
    {
        [HideInInspector]
        public string descriptor;
        [NonSerialized]
        public bool isExpanded;
        [NonSerialized] public bool showActions;
        [NonSerialized] public bool showAnimations;

        public void OnAfterDeserialize() {
        }

        public void OnBeforeSerialize()
        {
    #if UNITY_EDITOR
            descriptor = (prefab != null ? (view != null ? PrefabUtility.HasPrefabInstanceAnyOverrides(view, false) ? "* " : "" : "")
                         + prefab.name : "No Prefab" ) + $" ( name: {name} ) ";
    #endif
        }

        public GameObject view;
        public GameObject prefab;
        public string name;

        [Serializable]
        public class TransitionAnimations
        {
            [Header("Go right Open")] public string GoRightOpenStateName;
            [Header("Go left Open")] public string GoLeftOpenStateName;
            [Header("Go right Close")] public string GoRightCloseStateName;
            [Header("Go left Close")] public string GoLeftCloseStateName;
            [Header("Static Open")] public string StaticOpenStateName;
            [Header("Static Close")] public string StaticCloseStateName;
        }

        public TransitionAnimations animations;

        [Serializable]
        public class PathweaveAction
        {
            public string name;

            [SerializeField]
            public PathweaveEvent uiEvent = new PathweaveEvent();
        }
        public List<PathweaveAction> actions = new List<PathweaveAction>();
    }
}