
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AtacarZumbi : MonoBehaviour {
    [Range(0.1f, 10.0f)]
    private float distancia = 1.5f;
    private GameObject Jogador;
    public int zumbividaAtual = 12;   
    void Start () {
        
        Jogador = GameObject.FindWithTag("Player");
    }
   
void Update () {
        
            if (Vector3.Distance(transform.position, Jogador.transform.position) < distancia)
            {
                if (Input.GetMouseButton(0))
                {
                    zumbividaAtual = zumbividaAtual - 3;
                }
            }            
        
        if (zumbividaAtual == 0)
        {
            Destroy(gameObject);
        }
    }
}
