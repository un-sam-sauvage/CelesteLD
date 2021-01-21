using System;
using System.Collections;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private bool _playerHere = false;
    private void OnCollisionEnter2D(Collision2D other)
    {
        _playerHere = true;
        if (_playerHere)
        {
            StartCoroutine(CloudMove());
            _playerHere = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        new WaitForSeconds(.5f);
        _playerHere = true;
    }

    IEnumerator CloudMove()
    {
        
        gameObject.transform.Translate(new Vector3(0, -1, 0));
        yield return new WaitForSeconds(.4f);
        gameObject.transform.Translate(new Vector3(0, 1, 0));
        yield return new WaitForSeconds(.4f);
        Debug.Log("big jump");
        
    }
}
