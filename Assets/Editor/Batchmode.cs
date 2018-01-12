using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections.Generic;

/// <summary>  
/// 命令行批处理工具类  
/// </summary>  
public class Batchmode
{

    static List<string> levels = new List<string>();
    static string keystoreFile = @"D:\keystore.txt";

    public static void BuildAndroid()
    {






        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (!scene.enabled) continue;
            levels.Add(scene.path);
        }
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
        string res = BuildPipeline.BuildPlayer(levels.ToArray(), "android.apk", BuildTarget.Android, BuildOptions.None);
        if (res.Length > 0)
            throw new Exception("BuildPlayer failure: " + res);
    }
}