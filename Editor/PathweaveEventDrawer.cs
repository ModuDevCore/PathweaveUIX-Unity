using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEditor.IMGUI.Controls;

using ModuDevCore.PathweaveUIX.Runtime.Events;
using ModuDevCore.PathweaveUIX.Data;
using ModuDevCore.PathweaveUIX.Data.Events;

namespace ModuDevCore.PathweaveUIX.Editor.Events {
    [CustomPropertyDrawer(typeof(PathweaveEvent))]
    public class PathweaveEventDrawer : PropertyDrawer
    {
        private float listenersHeight = 0;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty listeners = property.FindPropertyRelative("_listeners");
            SerializedProperty argumentTypes = property.FindPropertyRelative("_argumentTypes");

            float spacing = 6f;

            float typesHeight = GetTypesListHeight(argumentTypes);

            Rect typesRect = new Rect(
                position.x,
                position.y,
                position.width,
                typesHeight);

            DrawTypesList(typesRect, argumentTypes);

            ReorderableList list = new ReorderableList(
                property.serializedObject,
                listeners,
                true,
                true,
                true,
                true);

            list.drawHeaderCallback = rect =>
            {
                EditorGUI.LabelField(rect, "Listeners");
            };

            list.elementHeightCallback = index =>
            {
                return EditorGUIUtility.singleLineHeight + 4;
            };

            list.drawElementCallback = (rect, index, active, focused) =>
            {
                SerializedProperty element =
                    listeners.GetArrayElementAtIndex(index);

                SerializedProperty target =
                    element.FindPropertyRelative("target");

                SerializedProperty targetComponent =
                    element.FindPropertyRelative("targetComponent");

                SerializedProperty method =
                    element.FindPropertyRelative("methodName");

                rect.y += 2;

                float third = rect.width / 3f;

                Rect targetRect = new Rect(
                    rect.x,
                    rect.y,
                    third - 5,
                    EditorGUIUtility.singleLineHeight);

                Rect componentRect = new Rect(
                    rect.x + third,
                    rect.y,
                    third - 5,
                    EditorGUIUtility.singleLineHeight);

                Rect methodRect = new Rect(
                    rect.x + third * 2,
                    rect.y,
                    third,
                    EditorGUIUtility.singleLineHeight);

                // GAMEOBJECT
                // EditorGUI.PropertyField(
                //     targetRect,
                //     target,
                //     GUIContent.none);


                GameObject go = target.objectReferenceValue as GameObject;
                UnityEngine.Object targetObject = EditorGUI.ObjectField(
                    targetRect,
                    GUIContent.none,
                    targetComponent.objectReferenceValue == null ? go : targetComponent.objectReferenceValue,
                    typeof(UnityEngine.Object),
                    true
                );

                if(targetObject is GameObject _go){
                    target.objectReferenceValue = _go;
                    targetComponent.objectReferenceValue = null;
                }

                // COMPONENT POPUP
                if (go != null)
                {
                    Component[] components = go.GetComponents<Component>();
                    string methodLabel = "None";

                    if (targetComponent.objectReferenceValue != null)
                    {
                        var compType = targetComponent.objectReferenceValue.GetType();

                        var methods = compType.GetMethods(
                            BindingFlags.Instance |
                            BindingFlags.Public |
                            BindingFlags.NonPublic);

                        var matched = methods.FirstOrDefault(m => m.Name == method.stringValue);

                        if (matched != null)
                            methodLabel = GetMethodSignature(matched);
                        else
                            methodLabel = method.stringValue;
                    }
                    if (GUI.Button(
                        componentRect,
                        methodLabel,
                        EditorStyles.popup))
                    {
                        var dropdown = new UIEventMethodsDropdown(new AdvancedDropdownState(), Listener.GetClasses(go), argumentTypes);
                        dropdown.onSelect = methodInfo =>
                        {
                            property.serializedObject.Update();

                            Undo.RecordObject(property.serializedObject.targetObject, "Set Method");

                            targetComponent.objectReferenceValue = FindComponent(go, methodInfo);
                            method.stringValue = methodInfo.Name;

                            property.serializedObject.ApplyModifiedProperties();

                            EditorUtility.SetDirty(property.serializedObject.targetObject);
                        };
                        dropdown.Show(new Rect(
                            Event.current.mousePosition,
                            Vector2.zero));
                    }
                }
            };

            Rect listRect = new Rect(
                position.x,
                position.y + typesHeight + spacing,
                position.width,
                list.GetHeight());

            list.DoList(listRect);
            listenersHeight = list.GetHeight();
        }
        private Component FindComponent(GameObject go, MethodInfo methodInfo)
        {
            if (go == null || methodInfo == null)
                return null;

            Type declaringType = methodInfo.DeclaringType;

            Component[] components = go.GetComponents<Component>();

            foreach (var c in components)
            {
                if (c == null)
                    continue;

                if (c.GetType() == declaringType)
                    return c;
            }

            return null;
        }
        private static readonly Type[] TYPE_OPTIONS =
        {
            typeof(int),
            typeof(float),
            typeof(bool),
            typeof(string),
            typeof(Vector2),
            typeof(Vector3),
            typeof(GameObject),
        };

        private void DrawTypesList(Rect position, SerializedProperty list)
        {
            if (list == null)
                return;

            float line = EditorGUIUtility.singleLineHeight;
            float spacing = 4f;

            Rect headerRect = new Rect(
                position.x,
                position.y,
                position.width,
                line);

            EditorGUI.LabelField(headerRect, "Arguments", EditorStyles.boldLabel);

            float y = position.y + line + spacing;

            for (int i = 0; i < list.arraySize; i++)
            {
                SerializedProperty element =
                    list.GetArrayElementAtIndex(i);

                SerializedProperty typeName =
                    element.FindPropertyRelative("typeName");

                Rect popupRect = new Rect(
                    position.x,
                    y,
                    position.width - 30,
                    line);

                Rect removeRect = new Rect(
                    position.x + position.width - 25,
                    y,
                    25,
                    line);

                // =========================
                // TYPE BUTTON + DROPDOWN
                // =========================
                Type currentType = ArgumentType.ToType(typeName.stringValue);
                string label = string.IsNullOrEmpty(typeName.stringValue)
                    ? "None"
                    : GetTypeLabel(currentType);

                Texture icon = GetTypeIcon(currentType);

                GUIContent content = new GUIContent(label, icon);

                if (GUI.Button(popupRect, content, EditorStyles.popup))
                {
                    var dropdown = new UIArgumentTypeDropdown(
                        new AdvancedDropdownState(),
                        TYPE_OPTIONS
                    );

                    dropdown.onSelect = (Type selectedType) =>
                    {
                        typeName.stringValue = selectedType.FullName;
                        typeName.serializedObject.ApplyModifiedProperties();
                    };

                    dropdown.Show(popupRect);
                }

                // =========================
                // REMOVE
                // =========================
                if (GUI.Button(removeRect, "−"))
                {
                    list.DeleteArrayElementAtIndex(i);
                    break;
                }

                y += line + spacing;
            }

            // =========================
            // ADD NEW ARGUMENT
            // =========================
            Rect addRect = new Rect(
                position.x,
                y,
                120,
                line);

            if (GUI.Button(addRect, "+ Add"))
            {
                list.arraySize++;

                SerializedProperty newElement =
                    list.GetArrayElementAtIndex(list.arraySize - 1);

                newElement.FindPropertyRelative("typeName").stringValue =
                    TYPE_OPTIONS.Length > 0
                        ? TYPE_OPTIONS[0].FullName
                        : string.Empty;
            }
        }
        private string GetMethodSignature(MethodInfo method)
        {
            var parameters = method.GetParameters();

            if (parameters.Length == 0)
                return $"{method.Name}()";

            string args = string.Join(", ",
                parameters.Select(p => GetTypeLabel(p.ParameterType)));

            return $"{method.Name}({args})";
        }
        private string GetTypeLabel(Type type)
        {
            if (type == null)
                return "None";

            if (type == typeof(int)) return "int";
            if (type == typeof(float)) return "float";
            if (type == typeof(bool)) return "bool";
            if (type == typeof(string)) return "string";
            if (type == typeof(Vector2)) return "Vector2";
            if (type == typeof(Vector3)) return "Vector3";

            if (typeof(Component).IsAssignableFrom(type))
                return type.Name;

            if (typeof(UnityEngine.Object).IsAssignableFrom(type))
                return type.Name;

            return type.Name;
        }
        private Texture GetTypeIcon(Type type)
        {
            if (type == null)
                return EditorGUIUtility.IconContent("d_DefaultAsset Icon").image;

            // =========================
            // GameObject
            // =========================
            if (type == typeof(GameObject))
            {
                return EditorGUIUtility.ObjectContent(
                    null,
                    typeof(GameObject)).image;
            }

            // =========================
            // Components / MonoBehaviours
            // =========================
            if (typeof(Component).IsAssignableFrom(type))
            {
                // built-in component icon
                Texture builtIn =
                    EditorGUIUtility.ObjectContent(null, type).image;

                if (builtIn != null)
                    return builtIn;

                // custom MonoBehaviour icon
                MonoScript script = FindMonoScript(type);

                if (script != null)
                {
                    Texture scriptIcon =
                        AssetPreview.GetMiniThumbnail(script);

                    if (scriptIcon != null)
                        return scriptIcon;
                }
            }

            // =========================
            // Primitive Types
            // =========================
            if (type == typeof(int))
                return EditorGUIUtility.IconContent("d_FilterByType").image;

            if (type == typeof(float))
                return EditorGUIUtility.IconContent("d_FilterByLabel").image;

            if (type == typeof(bool))
                return EditorGUIUtility.IconContent("d_Toggle Icon").image;

            if (type == typeof(string))
                return EditorGUIUtility.IconContent("d_TextAsset Icon").image;

            if (type == typeof(Vector2))
                return EditorGUIUtility.IconContent("d_RectTransform Icon").image;

            if (type == typeof(Vector3))
                return EditorGUIUtility.IconContent("d_MoveTool").image;

            return EditorGUIUtility.IconContent("d_DefaultAsset Icon").image;
        }
        private MonoScript FindMonoScript(Type type)
        {
            string[] guids = AssetDatabase.FindAssets($"{type.Name} t:MonoScript");

            foreach (string guid in guids)
            {
                string path = AssetDatabase.GUIDToAssetPath(guid);

                MonoScript script =
                    AssetDatabase.LoadAssetAtPath<MonoScript>(path);

                if (script == null)
                    continue;

                if (script.GetClass() == type)
                    return script;
            }

            return null;
        }
        private float GetTypesListHeight(SerializedProperty list)
        {
            float line = EditorGUIUtility.singleLineHeight;
            float spacing = 4f;

            return
                line + spacing + // header
                (list.arraySize * (line + spacing)) +
                line + spacing; // add button
        }

        public override float GetPropertyHeight(
            SerializedProperty property,
            GUIContent label)
        {
            SerializedProperty argumentTypes =
                property.FindPropertyRelative("_argumentTypes");

            float height = GetTypesListHeight(argumentTypes);

            height += listenersHeight;

            return height + 6f;
        }
    }

    public class UIEventMethodsDropdown : AdvancedDropdown
    {
        private Type[] classes;
        private SerializedProperty argumentTypes;

        public Action<MethodInfo> onSelect;

        public UIEventMethodsDropdown(
            AdvancedDropdownState state,
            Type[] classes,
            SerializedProperty argumentTypes)
            : base(state)
        {
            this.classes = classes;
            this.argumentTypes = argumentTypes;

            minimumSize = new Vector2(250, 300);
        }

        // =========================
        // ITEM
        // =========================
        private class MethodDropdownItem : AdvancedDropdownItem
        {
            public MethodInfo Method;

            public MethodDropdownItem(string name, MethodInfo method)
                : base(name)
            {
                Method = method;
            }
        }

        // =========================
        // BUILD ROOT
        // =========================
        protected override AdvancedDropdownItem BuildRoot()
        {
            var root = new AdvancedDropdownItem("Choose Method");

            List<Type> argTypes = ToTypes(argumentTypes);

            foreach (var typeClass in classes)
            {
                if (typeClass == null)
                    continue;

                var classItem = new AdvancedDropdownItem(typeClass.Name);

                var methods = Listener.FindExactMethods(typeClass, argTypes.ToArray());

                foreach (var method in methods)
                {
                    string signature = BuildSignature(method);

                    var item = new MethodDropdownItem(signature, method);

                    classItem.AddChild(item);
                }

                if (classItem.children != null && classItem.children.Count() > 0)
                    root.AddChild(classItem);
            }

            return root;
        }

        // =========================
        // SELECT
        // =========================
        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            base.ItemSelected(item);

            if (item is MethodDropdownItem m)
            {
                onSelect?.Invoke(m.Method);
            }
        }

        // =========================
        // SIGNATURE
        // =========================
        private string BuildSignature(MethodInfo method)
        {
            var parameters = method.GetParameters();

            if (parameters.Length == 0)
                return $"{method.Name}()";

            string args = string.Join(", ",
                parameters.Select(p => GetTypeName(p.ParameterType)));

            return $"{method.Name}({args})";
        }

        private string GetTypeName(Type type)
        {
            if (type == typeof(int))
                return "int";

            if (type == typeof(float))
                return "float";

            if (type == typeof(bool))
                return "bool";

            if (type == typeof(string))
                return "string";

            if (type == typeof(Vector2))
                return "Vector2";

            if (type == typeof(Vector3))
                return "Vector3";

            if (typeof(Component).IsAssignableFrom(type))
                return type.Name;

            return type.Name;
        }

        // =========================
        // ARGUMENT PARSING
        // =========================
        private List<Type> ToTypes(SerializedProperty argumentTypes)
        {
            List<Type> result = new();

            if (argumentTypes == null || !argumentTypes.isArray)
                return result;

            for (int i = 0; i < argumentTypes.arraySize; i++)
            {
                SerializedProperty element =
                    argumentTypes.GetArrayElementAtIndex(i);

                SerializedProperty typeName =
                    element.FindPropertyRelative("typeName");

                if (typeName == null)
                    continue;

                string value = typeName.stringValue;

                if (string.IsNullOrEmpty(value))
                    continue;

                Type t = ArgumentType.ToType(value);

                if (t != null)
                    result.Add(t);
            }

            return result;
        }
    }
    public class UIArgumentTypeDropdown : AdvancedDropdown
    {
        private Type[] typeOptions;
        private static readonly Dictionary<Type, Texture> iconCache = new();

        public Action<Type> onSelect;

        public UIArgumentTypeDropdown(
            AdvancedDropdownState state,
            Type[] typeOptions)
            : base(state)
        {
            this.typeOptions = typeOptions;

            minimumSize = new Vector2(250, 350);
        }
        public class TypeDropdownItem : AdvancedDropdownItem
        {
            public Type Type;

            public TypeDropdownItem(
                string name,
                Type type,
                Texture2D iconTexture)
                : base(name)
            {
                Type = type;

                icon = iconTexture;
            }
        }

        protected override AdvancedDropdownItem BuildRoot()
        {
            var root = new AdvancedDropdownItem("Select Type");

            // =========================
            // BASE TYPES
            // =========================
            var baseGroup = new AdvancedDropdownItem("Types");

            foreach (var t in typeOptions)
            {
                if (t == null)
                    continue;

                baseGroup.AddChild(
                    new TypeDropdownItem(t.Name, t, GetTypeIcon(t) as Texture2D));
            }

            if (baseGroup.children.Count() > 0)
                root.AddChild(baseGroup);

            // =========================
            // COMPONENTS
            // =========================
            var componentGroup = new AdvancedDropdownItem("Components");

            // =========================
            // BASE UNITY TYPES
            // =========================
            componentGroup.AddChild(
                new TypeDropdownItem(
                    "Object",
                    typeof(UnityEngine.Object),
                    GetTypeIcon(typeof(UnityEngine.Object))  as Texture2D));

            componentGroup.AddChild(
                new TypeDropdownItem(
                    "Component",
                    typeof(Component),
                    GetTypeIcon(typeof(Component)) as Texture2D));

            // =========================
            // ALL DERIVED COMPONENTS
            // =========================

            var components = TypeCache.GetTypesDerivedFrom<Component>()
                .Where(t => !t.IsAbstract && !t.IsGenericType)
                .OrderBy(t => t.Name);

            foreach (var comp in components)
            {
                componentGroup.AddChild(
                    new TypeDropdownItem(comp.Name, comp, GetTypeIcon(comp) as Texture2D));
            }

            root.AddChild(componentGroup);

            return root;
        }

        protected override void ItemSelected(AdvancedDropdownItem item)
        {
            base.ItemSelected(item);

            if (item is TypeDropdownItem typedItem)
            {
                onSelect?.Invoke(typedItem.Type);
            }
        }
        private Texture GetTypeIcon(Type type)
        {
            if (type == null)
                return EditorGUIUtility.IconContent("d_DefaultAsset Icon").image;

            if (iconCache.TryGetValue(type, out var cached))
                return cached;

            Texture result;

            // =========================
            // GameObject
            // =========================
            if (type == typeof(GameObject))
            {
                result = EditorGUIUtility.ObjectContent(null, typeof(GameObject)).image;
            }

            // =========================
            // Component / MonoBehaviour
            // =========================
            else if (typeof(Component).IsAssignableFrom(type))
            {
                result = EditorGUIUtility.ObjectContent(null, type).image;

                if (result == null)
                {
                    MonoScript script = FindMonoScript(type);

                    if (script != null)
                    {
                        result = AssetPreview.GetMiniThumbnail(script);
                    }
                }
            }

            // =========================
            // Primitive types
            // =========================
            else if (type == typeof(int))
                result = EditorGUIUtility.IconContent("d_FilterByType").image;

            else if (type == typeof(float))
                result = EditorGUIUtility.IconContent("d_FilterByLabel").image;

            else if (type == typeof(bool))
                result = EditorGUIUtility.IconContent("d_Toggle Icon").image;

            else if (type == typeof(string))
                result = EditorGUIUtility.IconContent("d_TextAsset Icon").image;

            else if (type == typeof(Vector2))
                result = EditorGUIUtility.IconContent("d_RectTransform Icon").image;

            else if (type == typeof(Vector3))
                result = EditorGUIUtility.IconContent("d_MoveTool").image;

            else
                result = EditorGUIUtility.IconContent("d_DefaultAsset Icon").image;

            // =========================
            // CACHE STORE (never null cache)
            // =========================
            iconCache[type] = result;

            return result;
        }
        private MonoScript FindMonoScript(Type type)
        {
            string[] guids = AssetDatabase.FindAssets($"{type.Name} t:MonoScript");

            foreach (string guid in guids)
            {
                string path = AssetDatabase.GUIDToAssetPath(guid);

                MonoScript script =
                    AssetDatabase.LoadAssetAtPath<MonoScript>(path);

                if (script == null)
                    continue;

                if (script.GetClass() == type)
                    return script;
            }

            return null;
        }
    }
}