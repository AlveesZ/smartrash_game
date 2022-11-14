using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Conversation : MonoBehaviour
{
    public int Counter = 0;
    public Text hud_text;

    public void Talk()
    {
        
        
       if (Input.GetKeyDown(KeyCode.Space))
       {    
            Counter += 1;

            if (Counter == 1)
            {

             hud_text.text = "Pete: Opa Kate! Manda ver...";
                    
            }

            if (Counter == 2)
            {

                hud_text.text = "Kate: Sabia que os dispositivos eletrônicos possuem vários materiais tóxicos...\n Se forem descartados de forma incorreta esses materiais podem contaminar o solo\n e os lençóis freáticos, colocando em risco a saúde pública.";



            }
            if (Counter == 3)
            {
                hud_text.text = "Kate: É bem simples Pete! Vá até a localização que vou mandar e faça a separação correta\n dos lixos eletrônicos! Lembre - se, cada objeto eletrônico tem sua caçamba específica e os\n que não forem eletrônicos devem ser separados na caçamba amarela, a que está na diagonal.\n Cuidado! Se descartar errado, além de estar poluindo ainda mais o planeta,\n você perde pontos e recebe menos!";
            }
            if (Counter == 4)
            {
                hud_text.text = "Pete: Pode deixar Kate! To indo pra lá agora!...\n (Aperte espaço para ir ao jogo.)";
            }
            if (Counter == 5)
            {
                SceneManager.LoadScene("controller");
            }
        }            
        
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Talk();
    }
}
