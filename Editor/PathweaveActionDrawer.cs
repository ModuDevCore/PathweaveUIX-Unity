using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;

using ModuDevCore.PathweaveUIX.Runtime.Actions;
using ModuDevCore.PathweaveUIX.Runtime.UI;
using ModuDevCore.PathweaveUIX.Data;

namespace ModuDevCore.PathweaveUIX.Editor.UI
{
    [CustomPropertyDrawer(typeof(PathweaveAction))]
    public class PathweaveActionDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 0f;

            height += EditorGUIUtility.singleLineHeight;
            height += 4f;

            height += EditorGUIUtility.singleLineHeight;
            height += 4f;

            height += EditorGUIUtility.singleLineHeight;
            height += 4f;

            SerializedProperty selectedAction =
                property.FindPropertyRelative("selectedAction");

            if (!string.IsNullOrEmpty(selectedAction.stringValue))
            {
                PathweaveAction runtimeAction =
                    GetTargetObjectOfProperty(property) as PathweaveAction;

                if (runtimeAction != null)
                {
                    var actions = runtimeAction.Actions;

                    if (
                        actions == null ||
                        actions.Count == 0 ||
                        !actions.TryGetValue(selectedAction.stringValue, out var signature) ||
                        signature == null ||
                        signature.argumentTypes == null ||
                        signature.argumentTypes.Count == 0
                    )
                    {
                        height += EditorGUIUtility.singleLineHeight;
                        height += 6f;
                    }
                    else
                    {
                        height += EditorGUIUtility.singleLineHeight;
                        height += 6f;

                        height +=
                            (EditorGUIUtility.singleLineHeight + 4f) *
                            signature.argumentTypes.Count;
                    }
                }
            }
            return height;
        }

        public override void OnGUI(Rect position,
                                   SerializedProperty property,
                                   GUIContent label)
        {
            SerializedProperty actionType =
                property.FindPropertyRelative("actionType");

            SerializedProperty selectedAction =
                property.FindPropertyRelative("selectedAction");

            SerializedProperty arguments =
                property.FindPropertyRelative("arguments");

            PathweaveAction runtimeAction =
                GetTargetObjectOfProperty(property) as PathweaveAction;

            if (runtimeAction == null)
                return;

            Rect rect = position;

            rect.height = EditorGUIUtility.singleLineHeight;

            EditorGUI.LabelField(rect,
                                 "UI Action Button",
                                 EditorStyles.boldLabel);

            rect.y += EditorGUIUtility.singleLineHeight + 4f;

            EditorGUI.PropertyField(rect, actionType);

            rect.y += EditorGUIUtility.singleLineHeight + 4f;

            DrawActionPopup(rect,
                            runtimeAction,
                            selectedAction);

            rect.y += EditorGUIUtility.singleLineHeight + 6f;

            DrawArguments(rect,
                          runtimeAction,
                          selectedAction,
                          arguments);

            property.serializedObject.ApplyModifiedProperties();
        }

        private void DrawActionPopup(Rect rect,
                                     PathweaveAction runtimeAction,
                                     SerializedProperty selectedAction)
        {
            var actions = runtimeAction.Actions;

            if (actions == null || actions.Count == 0)
            {
                EditorGUI.HelpBox(rect,
                                  "No actions available",
                                  MessageType.Warning);

                return;
            }

            string[] keys = new string[actions.Count + 1];

            keys[0] = "None";

            int i = 1;

            foreach (var kv in actions)
                keys[i++] = kv.Key;

            int currentIndex = 0;

            if (!string.IsNullOrEmpty(selectedAction.stringValue))
            {
                for (int j = 1; j < keys.Length; j++)
                {
                    if (keys[j] == selectedAction.stringValue)
                    {
                        currentIndex = j;
                        break;
                    }
                }
            }

            int newIndex =
                EditorGUI.Popup(rect,
                                "Action",
                                currentIndex,
                                keys);

            selectedAction.stringValue =
                newIndex == 0
                ? null
                : keys[newIndex];
        }

        private void DrawArguments(Rect rect,
                                   PathweaveAction runtimeAction,
                                   SerializedProperty selectedAction,
                                   SerializedProperty arguments)
        {
            if (string.IsNullOrEmpty(selectedAction.stringValue))
                return;

            var actions = runtimeAction.Actions;

            if (!actions.TryGetValue(selectedAction.stringValue, out var signature))
                return;

            var types = signature.argumentTypes;

            if (types == null || types.Count == 0)
            {
                EditorGUI.HelpBox(rect, "No arguments required", MessageType.Info);
                return;
            }

            while (arguments.arraySize < types.Count)
                arguments.InsertArrayElementAtIndex(arguments.arraySize);

            EditorGUI.LabelField(rect, "Arguments", EditorStyles.boldLabel);
            rect.y += EditorGUIUtility.singleLineHeight + 4f;

            for (int i = 0; i < types.Count; i++)
            {
                var argument = arguments.GetArrayElementAtIndex(i);

                var stringValue = argument.FindPropertyRelative("stringValue");
                var objectValue = argument.FindPropertyRelative("objectValue");
                var argumentTypeProp = argument.FindPropertyRelative("argumentType");

                Type argType = ArgumentType.ToType(types[i].typeName);

                Rect left = new Rect(rect.x, rect.y, 140, EditorGUIUtility.singleLineHeight);
                Rect right = new Rect(rect.x + 145, rect.y, rect.width - 145, EditorGUIUtility.singleLineHeight);

                EditorGUI.LabelField(left, types[i].typeName);

                // =========================
                // int
                // =========================
                if (argType == typeof(int))
                {
                    int value = 0;
                    int.TryParse(stringValue.stringValue, out value);

                    value = EditorGUI.IntField(right, value);
                    stringValue.stringValue = value.ToString();
                }

                // =========================
                // float
                // =========================
                else if (argType == typeof(float))
                {
                    float value = 0f;

                    float.TryParse(
                        stringValue.stringValue,
                        NumberStyles.Float,
                        CultureInfo.InvariantCulture,
                        out value);

                    value = EditorGUI.FloatField(right, value);

                    stringValue.stringValue =
                        value.ToString(CultureInfo.InvariantCulture);
                }

                // =========================
                // bool
                // =========================
                else if (argType == typeof(bool))
                {
                    bool value = false;
                    bool.TryParse(stringValue.stringValue, out value);

                    value = EditorGUI.Toggle(right, value);
                    stringValue.stringValue = value.ToString();
                }

                // =========================
                // string
                // =========================
                else if (argType == typeof(string))
                {
                    stringValue.stringValue =
                        EditorGUI.TextField(right, stringValue.stringValue);
                }

                // =========================
                // Vector2
                // =========================
                else if (argType == typeof(Vector2))
                {
                    Vector2 value = Vector2.zero;

                    if (!string.IsNullOrEmpty(stringValue.stringValue))
                        JsonUtility.FromJsonOverwrite(stringValue.stringValue, value);

                    value = EditorGUI.Vector2Field(right, GUIContent.none, value);

                    stringValue.stringValue = JsonUtility.ToJson(value);
                }

                // =========================
                // Vector3
                // =========================
                else if (argType == typeof(Vector3))
                {
                    Vector3 value = Vector3.zero;

                    if (!string.IsNullOrEmpty(stringValue.stringValue))
                        JsonUtility.FromJsonOverwrite(stringValue.stringValue, value);

                    value = EditorGUI.Vector3Field(right, GUIContent.none, value);

                    stringValue.stringValue = JsonUtility.ToJson(value);
                }

                // =========================
                // Unity Objects (GameObject + Components)
                // =========================
                else if (typeof(UnityEngine.Object).IsAssignableFrom(argType))
                {
                    UnityEngine.Object obj = objectValue.objectReferenceValue;

                    obj = EditorGUI.ObjectField(right, obj, argType, true);

                    objectValue.objectReferenceValue = obj;
                }

                // =========================
                // fallback
                // =========================
                else
                {
                    stringValue.stringValue =
                        EditorGUI.TextField(right, stringValue.stringValue);
                }

                // sync type
                var typeName = argumentTypeProp.FindPropertyRelative("typeName");
                typeName.stringValue = types[i].typeName;

                rect.y += EditorGUIUtility.singleLineHeight + 4f;
            }
        }

        private object GetTargetObjectOfProperty(SerializedProperty prop)
        {
            if (prop == null)
                return null;

            string path =
                prop.propertyPath.Replace(".Array.data[", "[");

            object obj =
                prop.serializedObject.targetObject;

            string[] elements = path.Split('.');

            foreach (var element in elements)
            {
                if (element.Contains("["))
                {
                    string elementName =
                        element.Substring(0, element.IndexOf("["));

                    int index =
                        Convert.ToInt32(
                            element.Substring(
                                element.IndexOf("["))
                                .Replace("[", "")
                                .Replace("]", "")
                        );

                    obj = GetValue(obj, elementName, index);
                }
                else
                {
                    obj = GetValue(obj, element);
                }
            }

            return obj;
        }

        private object GetValue(object source, string name)
        {
            if (source == null)
                return null;

            Type type = source.GetType();

            while (type != null)
            {
                var field =
                    type.GetField(name,
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance);

                if (field != null)
                    return field.GetValue(source);

                var property =
                    type.GetProperty(name,
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Public |
                    System.Reflection.BindingFlags.Instance);

                if (property != null)
                    return property.GetValue(source);

                type = type.BaseType;
            }

            return null;
        }

        private object GetValue(object source,
                                string name,
                                int index)
        {
            IEnumerable<object> enumerable =
                GetValue(source, name) as IEnumerable<object>;

            if (enumerable == null)
                return null;

            return enumerable.ElementAt(index);
        }
    }
}