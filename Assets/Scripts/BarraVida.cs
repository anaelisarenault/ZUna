using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour {
    public Image barraVida;
    public int fase;
    public static float vidaMax = 100, vidaAtual;
    
    // Use this for initialization
    void Start () {
        vidaAtual = vidaMax;
	}
   
	// Update is called once per frame
	void Update () {
        if (vidaAtual >= vidaMax) {
            vidaAtual = vidaMax;
        }

        barraVida.rectTransform.sizeDelta = new Vector2(vidaAtual/vidaMax  * 800, 36);

        if (vidaAtual <= 0) {

            if (fase == 1) {
                SceneManager.LoadScene("Andar 1");
            }
            else if (fase == 2)
            {
                SceneManager.LoadScene("Andar 2");
            }

        }

	}

}
