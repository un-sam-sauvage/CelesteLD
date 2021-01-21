﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * speed));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}