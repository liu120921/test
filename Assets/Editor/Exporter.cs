using UnityEngine;
using UnityEditor;


public class Exporter// : Editor
{
    //[MenuItem("exp/ex")]
    static void ExportCom()
    {
        Debug.Log("begin export p");
        //string[] paths = { "Assets/Scenes", "Assets/Profeb" };
        //AssetDatabase.ExportPackage(paths, "co.unitypackage", ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Recurse);
        AssetDatabase.ExportPackage("Assets/Scenes/test.unity", "co.unitypackage", ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Recurse);
        Debug.Log("done exp");
    }

    static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/test.unity" };
        BuildPipeline.BuildPlayer(scenes, "pa.a", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}