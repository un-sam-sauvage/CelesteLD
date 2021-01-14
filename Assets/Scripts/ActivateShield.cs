using UnityEngine;

public class ActivateShield : MonoBehaviour
{
    private bool _isActivated = false;
    public GameObject doorToActivate;
    private void OnTriggerEnter(Collider other)
    {
        if (!_isActivated)
        {
            doorToActivate.GetComponent<ShieldToActivateDoor>().nbShieldActivated++;
            _isActivated = true;
        }
    }
}
