using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItemValidation : MonoBehaviour
{
    public int pontos = 0;
    public bool Collected = false;
    public string deposit;

    public void Validator(string tagName, Collider other)
    {
        string tagNameDeposit = tagName + "Dep";

        if (other.gameObject.tag == tagName)
        { 
            tagNameDeposit = tagName + "Dep";

            if (deposit == "")
            {
                print("Pegue outro item!");

            }

            if (deposit == tagNameDeposit)
            {

                Collected = false;
                deposit = "";
                print("GANHOU PONTO! Parabéns! Você tornou o mundo um lugar melhor!");
                pontos += 1;

            }
            if (deposit != tagNameDeposit && deposit != "")
            {
                Collected = false;
                deposit = "";
                pontos -= 1;
                print("PERDEU PONTO! Você contribuiu com 10% na poluição do Mundo!");
            }

        }
        if (Collected == false)
        {
            if (other.gameObject.tag == tagName)
            {
                other.gameObject.SetActive(false);
                print("objeto coletado!");
                deposit = tagNameDeposit;                 // alterar tag do deposito de lixos não eletronicos
                Collected = true;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Validator(other.gameObject.tag, other);  
    }
    
}
