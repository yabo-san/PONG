using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinuePlayingMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;
        if (sceneName == "CRAZY HAND SPLASH")
        {
            DestroyObject(gameObject);
        }
        else { 
        DontDestroyOnLoad(gameObject); }
	}
}
