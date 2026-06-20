using UnityEngine;
using UnityEditor;
using System.IO;

namespace ModuDevCore.PathweaveUIX.Editor
{
    public static class PathweaveMenu
    {
        private const string NEW_PAGE_PREFAB_GUID =
            "b317da4206c93c6cbae4d23ada388f8b";
        private const string BUTTON_PREFAB_GUID =
            "49e25970ab91997279abd27b318f3bd0";

        [MenuItem("Assets/Create/Pathweave/New Page", false, 10)]
        public static void CreateNewPage()
        {
            string prefabPath = AssetDatabase.GUIDToAssetPath(
                NEW_PAGE_PREFAB_GUID
            );

            GameObject sourcePrefab =
                AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);

            if (sourcePrefab == null)
            {
                Debug.LogError("Source prefab not found");
                return;
            }

            GameObject instance = (GameObject)Object.Instantiate(sourcePrefab);

            instance.name = "New Page";

            string folder = GetSelectedFolder();
            string path = AssetDatabase.GenerateUniqueAssetPath(
                $"{folder}/NewPage.prefab"
            );

            GameObject prefabAsset = PrefabUtility.SaveAsPrefabAsset(
                instance,
                path
            );

            Object.DestroyImmediate(instance);

            Selection.activeObject = prefabAsset;
        }

        private static string GetSelectedFolder()
        {
            string path = "Assets";

            foreach (Object obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
            {
                string selectedPath = AssetDatabase.GetAssetPath(obj);

                if (!string.IsNullOrEmpty(selectedPath))
                {
                    if (Directory.Exists(selectedPath))
                        return selectedPath;
                }
            }

            return path;
        }
        [MenuItem("GameObject/UI/Pathweave/Button", false, 10)]
        public static void CreateButton(MenuCommand command)
        {
            string prefabPath = AssetDatabase.GUIDToAssetPath(
                BUTTON_PREFAB_GUID
            );

            GameObject prefab =
                AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);

            if (prefab == null)
            {
                Debug.LogError("PathweaveButton prefab not found");
                return;
            }

            GameObject instance =
                Object.Instantiate(prefab);
            instance.name = prefab.name;

            GameObject parent =
                command.context as GameObject;

            if (parent == null)
            {
                Canvas canvas =
                    Object.FindFirstObjectByType<Canvas>();

                if (canvas != null)
                    parent = canvas.gameObject;
            }

            if (parent != null)
                instance.transform.SetParent(parent.transform, false);

            Undo.RegisterCreatedObjectUndo(instance, "Create Pathweave Button");
            Selection.activeGameObject = instance;
        }
    }
}