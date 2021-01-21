using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class MovingPlateforme : MonoBehaviour
{
    private Transform platform;
    public Transform player;

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

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            player.transform.SetParent(platform.transform);
            Debug.Log("Heloo");
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            player.transform.SetParent(null);
        }
    }
    public void Reloop()
    {
        Sequence mySequence1 = DOTween.Sequence();
        mySequence1.Append(transform.DOMoveX(transform.position.x - posEnd, 3));
        mySequence1.AppendCallback(Start);
    }
}
