using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarEnemigos : MonoBehaviour
{
    public GameObject Enemy;
    Vector2 posicion;
    private void Start()
    {
        Posicion();
        Generar();
    }
    private void Update()
    {
        Posicion();
    }
    void Generar()
    {
        Invoke("Generar", 2f);
        Instantiate(Enemy, posicion, transform.rotation);
    }
    void Posicion()
    {
        posicion = new Vector2(Random.Range(-7.9f, 7.9f), transform.position.y);
    }

}
