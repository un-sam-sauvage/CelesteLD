﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public GameObject panel;

    private bool _bool;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_bool)
        {
            Debug.Log("Activé");
            panel.SetActive(true);
            _bool = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _bool)
        {
            Debug.Log("Désactivé");
            panel.SetActive(false);
            _bool = false;
        }
    }

    public void ChoseLevel(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
            case 4:
                SceneManager.LoadScene(4);
                break;
            case 5:
                SceneManager.LoadScene(5);
                break;
            case 6:
                SceneManager.LoadScene(6);
                break;
            case 7:
                SceneManager.LoadScene(7);
                break;
            case 8:
                SceneManager.LoadScene(8);
                break;
        }
    }
}
