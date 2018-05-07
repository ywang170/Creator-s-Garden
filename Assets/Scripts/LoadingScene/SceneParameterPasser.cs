using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneParameterPasser
{
    public const string NEXT_SCENE_KEY = "nextScene";
    public const string LOADING_SCENE_NAME = "Loading";
    private static Dictionary<string, string> parameters;

    public static void loadScene(
        string sceneName, 
        Dictionary<string, string> parameters = null)
    {
        if (parameters == null)
        {
            parameters = new Dictionary<string, string>();
        }
        if (!parameters.ContainsKey(NEXT_SCENE_KEY))
        {
            parameters.Add(NEXT_SCENE_KEY, sceneName);
        }
        SceneParameterPasser.parameters = parameters;
        SceneManager.LoadScene(LOADING_SCENE_NAME);
    }

    public static Dictionary<string, string> getParameters()
    {
        return SceneParameterPasser.parameters;
    }
}
