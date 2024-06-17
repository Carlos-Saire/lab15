using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    public float Speed;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(0,-Speed);
    }


}
