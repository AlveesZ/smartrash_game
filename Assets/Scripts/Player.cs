using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public int pontos = 0;
    public bool Collected = false;
    public string objeto;
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tablet")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }

            if (objeto == "TabletDep")
            {
               
                Collected = false;
                objeto = "";
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");
                pontos += 1;

            }
            if (objeto != "TabletDep" && objeto != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Mouse")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }
            if (objeto == "MouseDep")
            {
                objeto = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (objeto != "MouseDep" && objeto != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Key")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }
            if (objeto == "KeyDep")
            {
                objeto = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (objeto != "KeyDep" && objeto != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Cam")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }
            if (objeto == "CamDep")
            {
                objeto = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (objeto != "CamDep" && objeto != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (other.gameObject.tag == "Screen")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }
            if (objeto == "ScreenDep")
            {
                objeto = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if (objeto != "ScreedDep" && objeto != "")
            {
                pontos -= 1;
                print(" PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }
            
        }
        if (other.gameObject.tag == "Laptop")
        {
            if (objeto == "")
            {
                print("Pegue outro item!");

            }
            if (objeto == "LapDep")
            {
                objeto = "";
                pontos += 1;
                Collected = false;
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");


            }
            if(objeto != "LapDep" && objeto != "")
            {
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
       
        if (Collected == false)
        {
            if (other.gameObject.tag == "NoEletronic")
            {
                other.gameObject.SetActive(false);
                print("objeto coletado!");
                objeto = "NoEletronic";
                Collected = true;


            }
            
            if (other.gameObject.tag == "ScreenDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "ScreenDep";
                
            }

            if (other.gameObject.tag == "MouseDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "MouseDep";
                
            }

            if (other.gameObject.tag == "LapDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "LapDep";
                
            }

            if (other.gameObject.tag == "CamDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "CamDep";
                
            }
            if (other.gameObject.tag == "KeyDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "KeyDep";
                
            }
            if (other.gameObject.tag == "TabletDep")
            {
                other.gameObject.SetActive(false);
                print("Objeto Coletado!");
                Collected = true;
                objeto = "TabletDep";
                
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
        float playerVelocity = 10.0f;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(direction * playerVelocity * Time.deltaTime);
    }
}
