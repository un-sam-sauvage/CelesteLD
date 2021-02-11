using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class Playerpos : MonoBehaviour
{

    [SerializeField] private bool isSnapped;


    [SerializeField] private float yPos;

    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }


    private void Update()
    {
        if (!spawnPoint)
        {
            Debug.LogWarning("SpawnPoint is required");
        }
        
        if (isSnapped)
        {
            gameObject.transform.position = spawnPoint.transform.position + new Vector3(0, yPos, 0);
        }
    }
}