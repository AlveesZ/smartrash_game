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

                hud_text.text = "Kate: Sabia que os dispositivos eletr�nicos possuem v�rios materiais t�xicos...\n Se forem descartados de forma incorreta esses materiais podem contaminar o solo\n e os len��is fre�ticos, colocando em risco a sa�de p�blica.";



            }
            if (Counter == 3)
            {
                hud_text.text = "Kate: � bem simples Pete! V� at� a localiza��o que vou mandar e fa�a a separa��o correta\n dos lixos eletr�nicos! Lembre - se, cada objeto eletr�nico tem sua ca�amba espec�fica e os\n que n�o forem eletr�nicos devem ser separados na ca�amba amarela, a que est� na diagonal.\n Cuidado! Se descartar errado, al�m de estar poluindo ainda mais o planeta,\n voc� perde pontos e recebe menos!";
            }
            if (Counter == 4)
            {
                hud_text.text = "Pete: Pode deixar Kate! To indo pra l� agora!...\n (Aperte espa�o para ir ao jogo.)";
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
