using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    [Header("Loading scene")]
    public int sceneID;

    [Header("Other objects")]
    public Image background;
    public Text progressText;

    // Use this for initialization
    void Start () {
        StartCoroutine(AsyncLoad());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        while(!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            progressText.text = string.Format("{0:0}", progress * 100);
            yield return null;
        }
    }
}
