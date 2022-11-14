using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_jogar : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
