using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    public int NoEletronics = 10;
    public int Camera = 1;
    public int Mouse = 2;
    public int KeyBoard = 3;
    public int Screen = 4;
    public int laptop = 5;
    public int Tablet = 6;
    public bool Collected = false;
    GameObject player = GameObject.FindGameObjectWithTag("Player");




    //public void OnTriggerEnter(Collider other)
    //{
            
          //  if (player.Collected == false)
          //  {
             //   if (other.gameObject.tag == "Player")
             //   {
             //       gameObject.SetActive(false);
             //       print("objeto coletado!");
              //      player.Collected = true;
                    

           //     }
         //   }
    //}
    
}
