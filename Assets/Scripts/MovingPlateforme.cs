using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateforme : MonoBehaviour
{
    private Transform platform;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Transform>();
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Movement>() != null)
        {
            other.transform.SetParent(platform.transform);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Movement>() != null)
        {
            other.transform.SetParent(null);
        }
    }
}
