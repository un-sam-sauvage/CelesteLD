using System;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Animator animator;
    public bool redCloud = false;
    public GameObject player;
    private bool _startCountdown = false;
    private float _countdown = 3f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        animator.SetBool("CloudCanMove", true);
        player = other.gameObject;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        animator.SetBool("CloudCanMove", false);
    }

    public void BigJumpTrue()
    {
        player.GetComponent<Movement>().jumpForce += 10;
    }

    public void BigJumpFalse()
    {
        player.GetComponent<Movement>().jumpForce -= 10;
        if (redCloud)
        {
            _startCountdown = true;
            //TODO faire disparaître le nuage
        }
    }

    private void Update()
    {
        if (_startCountdown)
        {
            _countdown -= Time.deltaTime;
        }

        if (_countdown <= 0)
        {
            //TODO faire réapparaître le nuage
            _startCountdown = false;
            _countdown = 3f;
        }
    }
}