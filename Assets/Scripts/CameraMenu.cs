using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    [Tooltip("level 0 = 1er niveau")]public GameObject[] levels;

    public void ChooseLevel(int levelNumber)
    {
        switch (levelNumber)
        {
            case 1:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[0].SetActive(true);
                }
                break;
            case 2:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[1].SetActive(true);
                }
                break;
            case 3:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[2].SetActive(true);
                }
                break;
            case 4:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[3].SetActive(true);
                }
                break;
            case 5:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[4].SetActive(true);
                }
                break;
            case 6:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[5].SetActive(true);
                }
                break;
            case 7:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[6].SetActive(true);
                }
                break;
            case 8:
                foreach (var lvl in levels)
                {
                    lvl.SetActive(false);
                    levels[7].SetActive(true);
                }
                break;
        }
    }
}
