using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    Text _text;
    int Puntos;
    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    private void Start()
    {
        Aumentar(0);    
    }
    public void Aumentar(int p)
    {
        Puntos =Puntos + p;
        _text.text = "Puntos : " + Puntos;
    }             
}
