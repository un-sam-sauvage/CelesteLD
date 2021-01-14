using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldToActivateDoor : MonoBehaviour
{
    public int nbShieldRecquire;
    public int nbShieldActivated;
    

    // Update is called once per frame
    void Update()
    {
        if (nbShieldRecquire == nbShieldActivated)
        {
            //TODO porte qui bouge
            Debug.Log("La porte s'ouvre");
        }
    }
}
