using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Dictionary<string, string> parametersFromLastScene = SceneParameterPasser.getParameters();
        if (parametersFromLastScene.ContainsKey(SceneParameterPasser.NEXT_SCENE_KEY))
        {
            StartCoroutine(startLoading(parametersFromLastScene[SceneParameterPasser.NEXT_SCENE_KEY]));	
        }
	}

    private IEnumerator startLoading(string sceneName)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;
        while(async.isDone == false)
        {
            if (async.progress == 0.9f)
            {
                yield return new WaitForSeconds(5);
                async.allowSceneActivation = true;
            }
        }
    }
}
