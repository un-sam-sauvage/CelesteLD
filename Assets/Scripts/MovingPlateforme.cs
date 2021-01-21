using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovingPlateforme : MonoBehaviour
{
    private Transform platform;
    public Transform player;
    [SerializeField]
    private float delay = 1.5f;
    [Header("Paramètres")]
    public float posStart = 3;
    public float posEnd = 3;
    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Transform>();
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMoveX(transform.position.x + posStart, 3));
        mySequence.AppendCallback(Reloop);
    }

    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                player.transform.SetParent(platform.transform);
                Debug.Log("Heloo");
                delay = Mathf.Clamp(delay, 0, Mathf.Infinity);
            }
         
            
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            player.transform.SetParent(null);
            Debug.Log("Heloo");
        }

        delay = 1;
    }

  
    public void Reloop()
    {
        Sequence mySequence1 = DOTween.Sequence();
        mySequence1.Append(transform.DOMoveX(transform.position.x - posEnd, 3));
        mySequence1.AppendCallback(Start);
    }
}
