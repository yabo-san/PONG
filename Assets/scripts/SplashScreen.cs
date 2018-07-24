﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    public string sceneToLoad;
    public int secTillScenesLoad;

	// Use this for initialization
	void Start () {
        Invoke("OpenNextScene", secTillScenesLoad);

	}
	
	// Update is called once per frame
	void OpenNextScene () {
        SceneManager.LoadScene(sceneToLoad);
        
	}

}
