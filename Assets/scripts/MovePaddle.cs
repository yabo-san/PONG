using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePaddle : MonoBehaviour {
    public float speed = 30;
    public string sceneToLoad;
    public int secTillScenesLoad;
    // Use this for initialization
    private void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("q")){
            Invoke("OpenNextScene", secTillScenesLoad);
        }
	}
    void OpenNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);

    }
}
