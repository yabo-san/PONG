using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour
{
    public float speed = 30;
    public string sceneToLoad1;
    public string sceneToLoad2;
    public string sceneToLoad3;
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
            Invoke("OpenNextScene1", secTillScenesLoad);
        }
        if (col.gameObject.name == "wall bottom")
        {
            Invoke("OpenNextScene2", secTillScenesLoad);
        }
        if (col.gameObject.name == "right goal")
        {
            Invoke("OpenNextScene3", secTillScenesLoad);
        }

    }
    void OpenNextScene1()
    {
        SceneManager.LoadScene(sceneToLoad1);

    }
    void OpenNextScene2()
    {
        SceneManager.LoadScene(sceneToLoad2);

    }
    void OpenNextScene3()
    {
        SceneManager.LoadScene(sceneToLoad3);

    }
}