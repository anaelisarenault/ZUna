using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Coletar : MonoBehaviour
{
   // public Text mensagem;
    public int chavei, pocao1i, pocao2i, canivetei;
    private int chavei1 = 0, pocao1i1 = 0, pocao2i1 = 0, canivetei1 = 0; 
    void OnTriggerEnter(Collider other)
    {
       // mensagem.text = "Aperte o botão esquerdo do mouse";
        if (chavei == 1)
        {
            chavei1 = 1;
        }
        if (pocao1i == 1)
        {
            pocao1i1 = 1;
        }
        if (pocao2i == 1)
        {
            pocao2i1 = 1;
        }
        if (canivetei == 1)
        {
            canivetei1 = 1;
        }       
       
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {
           // mensagem.text = "   ";
            if (chavei1 == 1)
            {
                Inventario.chavei = 1;
                Destroy(gameObject);
            }
            if (pocao1i1 == 1)
            {
                Inventario.pocao1i = 1;
                BarraVida.vidaAtual = BarraVida.vidaAtual + 30;
                Destroy(gameObject);
            }
            if (pocao2i1 == 1)
            {
                Inventario.pocao2i = 1;
                BarraVida.vidaAtual = BarraVida.vidaAtual + 50;
                Destroy(gameObject);
            }
            if (canivetei1 == 1)
            {
                Inventario.canivetei = 1;
                Destroy(gameObject);
            }           

        }
    }
}
