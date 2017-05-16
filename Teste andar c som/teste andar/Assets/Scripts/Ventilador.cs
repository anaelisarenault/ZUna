using UnityEngine;
using UnityEngine.UI;

public class Ventilador : MonoBehaviour {
    public Text mensagem;
    public Rigidbody ventilador;    
    void OnTriggerEnter(Collider other)
    {
     mensagem.text = "Aperte V para ligar/desligar o ventilador.";
                ventilador.AddRelativeTorque(0,20,0);          
    }
    
}
