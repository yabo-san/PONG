﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepaddle2 : MonoBehaviour {
    public float speed = 30;
    // Use this for initialization
    private void FixedUpdate()
    {
        float vertPress = Input.GetAxisRaw("Vertical Player 2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, vertPress) * speed;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
