using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    AudioSource _audioSource;
    public TextControl Puntos;
    public float Speed;
    public GameObject Bala;
    float horizontal;
    float vertical;
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _audioSource.Play();
           GameObject Go= Instantiate(Bala, transform.position, transform.rotation);
            Go.GetComponent<BalaControl>().Obtener(Puntos);
        }
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(Speed*horizontal,Speed*vertical);
    }

}
