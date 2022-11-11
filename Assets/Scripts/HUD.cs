using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    Text hud_text;    

    // Start is called before the first frame update
    void Start()
    {
        hud_text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hud_text.text = "Hello World!"  ;
    }
}
