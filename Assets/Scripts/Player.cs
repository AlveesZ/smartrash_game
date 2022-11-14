using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
    Animator animator;
    float playerVelocity = 5.0f;
    public int pontos = 0;
    public bool Collected = false;
    public string objeto;
    public string tagname;
    HUD textMessage;


    public void OnTriggerEnter(Collider other)
    {
        tagname = other.gameObject.tag;

        if (Collected == false)
        {
            if (tagname == "ScreenDep" || tagname == "MouseDep" || tagname == "LaptopDep" || tagname == "KeyDep" || tagname == "CamDep" || tagname == "TabletDep" || tagname == "NoEletronicDep")
            {
                other.gameObject.SetActive(false);
                print("Obejeto coletado!");
                print(tagname);
                objeto = tagname;
                Collected = true;
                print(Collected);
            }

        }
        if (Collected == true)
        {
            if (tagname == "Tablet" || tagname == "Screen" || tagname == "Mouse" || tagname == "Laptop" || tagname == "Key" || tagname == "Cam" || tagname == "NoEletronic")
            {
                if (objeto == "")
                {
                    print("Pegue outro item!");

                }

                if (objeto == tagname + "Dep")
                {

                    Collected = false;
                    objeto = "";
                    print("GANHOU PONTO! Parabens! Voce tornou o mundo um lugar melhor!");
                    print(pontos);
                    pontos += 1;

                }
                if (objeto != tagname + "Dep" && objeto != "")
                {
                    pontos -= 1;
                    print("PERDEU PONTO! Voce contribuiu com 10% na poluicao do Mundo!");
                    print(pontos);
                }

            }
        }
    }   
        void PlayerMove()
        {
            float mouseLocalX = Input.GetAxis("Mouse X") * 5.0f;
            transform.Rotate(0.0f, mouseLocalX, 0.0f);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                animator.SetBool("isMoving", true);
                float verticalInput = Input.GetAxis("Vertical");
                Vector3 direction = new Vector3(0.0f, 0.0f, verticalInput);
                transform.Translate(direction * playerVelocity * Time.deltaTime);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("isMoving", false);
            }
        }

        // Start is called before the first frame update
        void Start()
        {
             animator = GetComponent <Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            PlayerMove();
        } 
}     

