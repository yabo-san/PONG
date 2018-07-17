using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{

    public string scene1;
    public string scene2;
    public int secTillScenesLoad;

    // Use this for initialization
    void Update()
    {
        //Invoke("OpenNextScene", secTillScenesLoad);
        OpenNextScene();

    }

    // Update is called once per frame
    void OpenNextScene()
    {
        if (Input.GetKeyDown("d"))
        {
            SceneManager.LoadScene(scene1);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            SceneManager.LoadScene(scene2);
        }

    }
}
