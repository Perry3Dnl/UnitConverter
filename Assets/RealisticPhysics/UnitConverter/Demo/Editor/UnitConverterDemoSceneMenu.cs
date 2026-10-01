namespace RealisticPhysics.UnitConversion.Demo.Editor
{
    using RealisticPhysics.UnitConversion.Demo;
    using UnityEditor;
    using UnityEditor.SceneManagement;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public static class UnitConverterDemoSceneMenu
    {
        private const string DemoScenePath = "Assets/RealisticPhysics/UnitConverter/Demo/Scenes/UnitConverterRuntimeDemo.unity";

        [MenuItem("Tools/RealisticPhysics/UnitConverter/Create Runtime Demo Scene")]
        public static void CreateRuntimeDemoScene()
        {
            Scene scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            scene.name = "UnitConverterRuntimeDemo";

            GameObject demoObject = new GameObject("UnitConverter Runtime Demo");
            demoObject.AddComponent<UnitConverterRuntimeDemo>();

            GameObject cameraObject = new GameObject("Main Camera");
            cameraObject.tag = "MainCamera";
            Camera camera = cameraObject.AddComponent<Camera>();
            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = new Color(0.015f, 0.025f, 0.045f, 1f);
            camera.transform.position = new Vector3(0f, 0f, -10f);

            GameObject lightObject = new GameObject("Directional Light");
            Light light = lightObject.AddComponent<Light>();
            light.type = LightType.Directional;
            light.intensity = 1f;
            lightObject.transform.rotation = Quaternion.Euler(50f, -30f, 0f);

            EnsureFolder("Assets/RealisticPhysics/UnitConverter/Demo");
            EnsureFolder("Assets/RealisticPhysics/UnitConverter/Demo/Scenes");

            EditorSceneManager.SaveScene(scene, DemoScenePath);
            AssetDatabase.Refresh();
            EditorUtility.DisplayDialog(
                "UnitConverter Demo Scene Created",
                "The runtime demo scene was created at:\n" + DemoScenePath,
                "OK");
        }

        [MenuItem("Tools/RealisticPhysics/UnitConverter/Open Runtime Demo Scene")]
        public static void OpenRuntimeDemoScene()
        {
            if (!System.IO.File.Exists(DemoScenePath))
            {
                CreateRuntimeDemoScene();
                return;
            }

            EditorSceneManager.OpenScene(DemoScenePath, OpenSceneMode.Single);
        }

        private static void EnsureFolder(string path)
        {
            if (AssetDatabase.IsValidFolder(path))
            {
                return;
            }

            string[] parts = path.Split('/');
            string current = parts[0];

            for (int i = 1; i < parts.Length; i++)
            {
                string next = current + "/" + parts[i];

                if (!AssetDatabase.IsValidFolder(next))
                {
                    AssetDatabase.CreateFolder(current, parts[i]);
                }

                current = next;
            }
        }
    }
}
