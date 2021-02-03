using System;
using UnityEngine;

public class ActivateShield : MonoBehaviour
{
    public GameObject player;
    private bool _isActivated = false;
    public GameObject doorToActivate;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_isActivated)
        {
            doorToActivate.GetComponent<ShieldToActivateDoor>().nbShieldActivated++;
            _isActivated = true;
            player.GetComponent<Movement>().hasDashed = false;
            Destroy(gameObject, 1f);
        }
    }
}
