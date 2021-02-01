using System.Collections;
using DG.Tweening;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    private Animator _animator;

    public bool redCloud;

    private GameObject _player;

    private Vector3 _scale;

    private bool _startCountdown;
    private bool _isPlayer;

    private float _countdown = 3f;
    private float _jumpForce;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _player = GameObject.FindGameObjectWithTag("Player");
        _jumpForce = _player.GetComponent<Movement>().jumpForce;
        _scale = gameObject.transform.localScale;
        if (redCloud)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _animator.SetBool("CloudCanMove", true);
        if (other.transform.CompareTag("Player"))
        {
            _isPlayer = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        _animator.SetBool("CloudCanMove", false);
        if (other.transform.CompareTag("Player"))
        {
            _isPlayer = false;
        }
    }

    public void BigJumpTrue()
    {
        if (_isPlayer)
            _player.GetComponent<Movement>().jumpForce = _jumpForce + 10;
        if (redCloud)
        {
            StartCoroutine(ScaleCloud());
        }
    }

    IEnumerator ScaleCloud()
    {
        yield return new WaitForSeconds(.3f);
        gameObject.transform.DOScale(Vector3.zero,.5f);
        _startCountdown = true;
    }
    public void BigJumpFalse()
    {
        _player.GetComponent<Movement>().jumpForce = _jumpForce;

        _animator.SetBool("CloudCanMove", false);
    }

    private void Update()
    {
        if (_startCountdown)
        {
            _countdown -= Time.deltaTime;
        }

        if (_countdown <= 0)
        {
            gameObject.transform.DOScale(_scale,.5f);
            _startCountdown = false;
            _countdown = 3f;
        }
    }
}