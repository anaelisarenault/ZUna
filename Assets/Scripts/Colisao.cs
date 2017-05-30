using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour {

        void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            BarraVida.vidaAtual = BarraVida.vidaAtual - 5;
        }

    }
        }


