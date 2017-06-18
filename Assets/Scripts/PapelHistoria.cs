using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PapelHistoria : MonoBehaviour {
    [Range(0.1f, 10.0f)] public float distancia = 1.3f;
    private GameObject Jogador;
    public Image folha;

    void Start () {
       
        
        Jogador = GameObject.FindWithTag("Player");
	}
	
	
	void Update () {
        if (Vector3.Distance(transform.position, Jogador.transform.position) < distancia)
        {
            if (Input.GetMouseButton(0))
            {
                if (folha.enabled == false)
                {
                    folha.enabled = true;
                }
                else
                {
                    folha.enabled = false;
                }
            }
        }
        else {            
            folha.enabled = false;
        }
	}
}
