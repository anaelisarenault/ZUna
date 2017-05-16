using UnityEngine;
using UnityEngine.UI;

public class Ventilador : MonoBehaviour {
    public Text mensagem;
    public Rigidbody ventilador;    
    void OnTriggerEnter(Collider other)
    {
     mensagem.text = "16 ";
                ventilador.AddRelativeTorque(0,150,0);
        //static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

    }

}
