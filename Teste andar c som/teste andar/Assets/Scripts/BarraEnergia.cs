using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraEnergia : MonoBehaviour
{
    public Image barraEnergia;
    public static float energiaMax = 10, energiaAtual;
    void Start()
    {
        energiaMax = energiaAtual;
    }
    void Update()
    {        
       if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            barraEnergia.rectTransform.sizeDelta = new Vector2(energiaAtual * energiaMax * Time.deltaTime * 590, 34);

        }
    }
}
