using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private bool isTaken =false;
    private float countdownToReactivate = 3f;
    public GameObject player;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Movement>())
        {
            isTaken = true;
            //TODO changement de frame pour montrer que c'est pris
            player.GetComponent<Movement>().hasDashed = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTaken)
        {
            countdownToReactivate -= Time.deltaTime;
        }

        if (countdownToReactivate <= 0)
        {
            isTaken = false;
            countdownToReactivate = 3f;
            //TODO remettre la frame du diamant qui est disponible
        }
    }
}
