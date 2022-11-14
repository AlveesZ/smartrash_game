using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_controle : MonoBehaviour
{
    public void irControle()
    {
        SceneManager.LoadScene("controller");
    }
}
