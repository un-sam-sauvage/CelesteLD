using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPikes : MonoBehaviour
{
    public GameObject respawn;
    public int sceneNumber;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneNumber);
            other.gameObject.transform.position = respawn.transform.position;
        }
    }

    public void ClearRespawnPoint()
    {
        respawn = null;
    }

    public void AddRespawnPoint()
    {
        respawn = GameObject.FindGameObjectWithTag("spawn");
    }
}
