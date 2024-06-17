using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScene : MonoBehaviour
{
    public string Name;
    public void LoadScene()
    {
        SceneManager.LoadScene(Name);
    }
}
