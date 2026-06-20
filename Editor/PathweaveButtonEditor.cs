using UnityEditor;
using ModuDevCore.PathweaveUIX.Runtime.UI;
using ModuDevCore.PathweaveUIX.Runtime.Actions;

namespace ModuDevCore.PathweaveUIX.Editor.UI
{
    [CustomEditor(typeof(PathweaveButton))]
    public class PathweaveButtonEditor : UnityEditor.UI.ButtonEditor
    {
        private SerializedProperty action;

        protected override void OnEnable()
        {
            base.OnEnable();

            action = serializedObject.FindProperty("action");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            base.OnInspectorGUI();

            EditorGUILayout.Space(10);

            EditorGUILayout.PropertyField(action);

            serializedObject.ApplyModifiedProperties();
        }
    }
}