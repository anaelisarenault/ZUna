using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour {

        void OnTriggerEnter(Collider other) {
        
        BarraVida.vidaAtual = BarraVida.vidaAtual - 1;

    }
        }


