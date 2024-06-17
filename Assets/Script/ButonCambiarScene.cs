using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButonCambiarScene : MonoBehaviour
{
    Button _boton;
    public CambiarScene cambioDeScena;
    private void Awake()
    {
        _boton = GetComponent<Button>();
        _boton.onClick.AddListener(() => CambiarScene());
    }
    void CambiarScene()
    {
        cambioDeScena.LoadScene();
    }
}
