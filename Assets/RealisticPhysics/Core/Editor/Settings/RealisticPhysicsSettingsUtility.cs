namespace RealisticPhysics.Core.Editor.Settings
{
    using RealisticPhysics.Core.Settings;
    using UnityEditor;
    using UnityEngine;

    public static class RealisticPhysicsSettingsUtility
    {
        public static T FindSettings<T>() where T : RealisticPhysicsSettingsAsset
        {
            string[] guids = AssetDatabase.FindAssets($"t:{typeof(T).Name}");

            foreach (string guid in guids)
            {
                string path = AssetDatabase.GUIDToAssetPath(guid);
                T asset = AssetDatabase.LoadAssetAtPath<T>(path);

                if (asset != null)
                {
                    return asset;
                }
            }

            return null;
        }

        public static T FindOrCreateSettings<T>(string folder, string fileName)
            where T : RealisticPhysicsSettingsAsset
        {
            T existing = FindSettings<T>();

            if (existing != null)
            {
                return existing;
            }

            EnsureFolder(folder);

            string path = $"{folder}/{fileName}.asset";
            T asset = ScriptableObject.CreateInstance<T>();
            asset.EnsureDefaults();
            asset.ResetToRecommendedDefaults();

            AssetDatabase.CreateAsset(asset, path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            return asset;
        }

        public static void EnsureFolder(string folderPath)
        {
            if (AssetDatabase.IsValidFolder(folderPath))
            {
                return;
            }

            string[] parts = folderPath.Split('/');
            string current = parts[0];

            for (int index = 1; index < parts.Length; index++)
            {
                string next = $"{current}/{parts[index]}";

                if (!AssetDatabase.IsValidFolder(next))
                {
                    AssetDatabase.CreateFolder(current, parts[index]);
                }

                current = next;
            }
        }

        public static void SelectAndPing(Object asset)
        {
            Selection.activeObject = asset;
            EditorGUIUtility.PingObject(asset);
        }
    }
}
