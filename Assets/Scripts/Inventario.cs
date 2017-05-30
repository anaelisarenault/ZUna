using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{
    public static int chavei, pocao1i, pocao2i, canivetei;
    public Image chave, pocao1, pocao2, canivete;
    void Start()
    {
        chavei = 0;
        pocao1i = 0;
        pocao2i = 0;
        canivetei = 0;
    }

    void Update()
    {
        if (chavei == 1)
        {
            chave.enabled = true;
        }
        if (pocao1i == 1)
        {
            pocao1.enabled = true;
        }
        if (pocao2i == 1)
        {
            pocao2.enabled = true;
        }
        if (canivetei == 1)
        {
            canivete.enabled = true;
        }

    }
}

