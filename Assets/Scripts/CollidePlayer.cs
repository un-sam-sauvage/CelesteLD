using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePlayer : MonoBehaviour
{
    public GameObject player;
    private bool _isActivated;
    public GameObject doorToActivate;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doorToActivate.GetComponent<ShieldToActivateDoor>().nbShieldActivated++;
            _isActivated = true;
            player.GetComponent<Movement>().hasDashed = false;
            Destroy(gameObject, 1f);
        }
    }
}
