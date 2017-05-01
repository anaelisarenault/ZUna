using UnityEngine;
using UnityEngine.UI;

public class Ventilador : MonoBehaviour {
    public Text mensagem;
    public Rigidbody ventilador;
    private bool ligado = false;
    
    void OnTriggerEnter(Collider other)
    {
     mensagem.text = "Aperte V para ligar/desligar o ventilador.";
         if(Input.GetKeyDown(KeyCode.V))
             {
            if (ligado == false)
            {
                ventilador.AddForce(10, 0 , 0);
                ligado = true;
                mensagem.text = "";
            }
            else {
                ventilador.AddForce(0, 0, 0);
                ligado = false;
                mensagem.text = "";
            }
        }
        mensagem.text = "";
    }
    
}
