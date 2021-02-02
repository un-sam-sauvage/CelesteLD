using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldToActivateDoor : MonoBehaviour
{
    public int nbShieldRecquire;
    public int nbShieldActivated;

    public Transform point;
    // Update is called once per frame
    void Update()
    {
        Vector2 move = transform.position;
        if (nbShieldRecquire == nbShieldActivated)
        {
            //TODO porte qui bouge
            Debug.Log("La porte s'ouvre");
            transform.position = Vector2.MoveTowards(move, point.position, 0.5f);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
