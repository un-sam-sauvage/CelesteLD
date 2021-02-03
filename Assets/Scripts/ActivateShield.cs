using System;
using UnityEngine;

public class ActivateShield : MonoBehaviour
{
    public GameObject player;
    private bool _isActivated;
    public GameObject doorToActivate;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Nique Zebi");
        if (other.gameObject.CompareTag("Player"))
        {
            doorToActivate.GetComponent<ShieldToActivateDoor>().nbShieldActivated++;
            _isActivated = true;
            player.GetComponent<Movement>().hasDashed = false;
            Destroy(gameObject, 1f);
        }
    }
}
