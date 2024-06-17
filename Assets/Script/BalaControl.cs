using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControl : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    Animator _animator;
    public float Speed;
    TextControl Puntos;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(0,Speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Limite")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Speed = 0;
            _animator.SetTrigger("Empezar");
            Puntos.Aumentar(10);
            Destroy(gameObject,0.5f);
        }
        
    }
    public void Obtener(TextControl a)
    {
        Puntos = a;
    }
}
