using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour
{
    public float speed = 30;
    private string sceneToLoad;
    public string scene1;
    public string scene2;
    public string scene3;
    public int secTillScenesLoad;
    // Use this for initialization
    private void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw("Vertical");
        float horzPress = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horzPress, vertPress) * speed;
        
        //GetComponent<Rigidbody2D>().velocity = new Vector2(, 0) * speed;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //bottom or top
        if (col.gameObject.name == "wall top")
        {
            sceneToLoad = scene1;
            Invoke("OpenNextScene", secTillScenesLoad);
        }
        if (col.gameObject.name == "wall bottom")
        {
            sceneToLoad = scene2;
            Invoke("OpenNextScene", secTillScenesLoad);
        }
        if (col.gameObject.name == "right goal")
        {
            sceneToLoad = scene3;
            Invoke("OpenNextScene", secTillScenesLoad);
        }

    }
    void OpenNextScene()
    {
        SceneManager.LoadScene(sceneToLoad);

    }

}