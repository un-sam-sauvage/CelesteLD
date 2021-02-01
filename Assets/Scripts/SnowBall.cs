using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowBall : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * speed));
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = FindObjectOfType<GameManager>().respawn.position;
        }
    }
}
