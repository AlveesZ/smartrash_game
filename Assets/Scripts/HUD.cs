using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    Text hud_text;
    public Player player;
    
    public void showMessages()
    {
        if (player.Collected == true)
        {
            hud_text.text = "Objeto Coletado!";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        showMessages();
    }
}
