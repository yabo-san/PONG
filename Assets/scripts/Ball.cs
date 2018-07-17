using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    public float speed = 30;

    private Rigidbody2D rigidBody;

    private AudioSource AudioSource;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.right * speed;


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //leftpaddle or right paddle
        if ((col.gameObject.name == "left paddle") || (col.gameObject.name == "right paddle"))
        {
            handlePaddleHit(col);
        }
        //bottom or top
        if ((col.gameObject.name == "wall bottom") || (col.gameObject.name == "wall top"))
        {
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.wallBloop);
        }

        //left goal or right goal

        if ((col.gameObject.name == "left goal") || (col.gameObject.name == "right goal"))
        {
            SoundManager.Instance.PlayOneShot(SoundManager.Instance.goalBloop);
            //todo: update score UI

            if (col.gameObject.name == "left goal" ) {
                IncreaseTextUIScore("RightScoreUI");
            }
            if (col.gameObject.name == "right goal")
            {
                IncreaseTextUIScore("LeftScoreUI");
            }
            transform.position = new Vector2(0, 0);
        }

    }
    void handlePaddleHit(Collision2D col)
    {
        float y = ballHitPaddleWhere(transform.position, col.transform.position, col.collider.bounds.size.y);
        Vector2 dir = new Vector2();
        if (col.gameObject.name == "left paddle")
        {
            dir = new Vector2(1, y).normalized;
        }
        if (col.gameObject.name == "right paddle")
        {
            dir = new Vector2(-1, y).normalized;
        }
        rigidBody.velocity = dir * speed;
        SoundManager.Instance.PlayOneShot(SoundManager.Instance.hitPaddleBloop);
    }
    float ballHitPaddleWhere(Vector2 ball, Vector2 paddle, float paddleHeight)
    {
        return (ball.y - paddle.y) / paddleHeight;
    }

    void IncreaseTextUIScore(string TextUIName) {
        var TextUIComp = GameObject.Find(TextUIName).GetComponent<Text>();
        int score = int.Parse(TextUIComp.text);

        score++;

        TextUIComp.text = score.ToString();
    }
}
