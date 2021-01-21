using System;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Animator animator;
    private bool _bigJump = false;
    public GameObject player;
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
    }
}