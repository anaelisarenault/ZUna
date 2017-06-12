using UnityEngine;
using UnityEngine.UI;

public class Ventilador : MonoBehaviour {
    //public Text mensagem;
    public Rigidbody ventilador;
    public Rigidbody ventilador2;
    public bool ligado = false;

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetMouseButton(0))
        {
            //mensagem.text = "16 ";
            if (ligado == false)
            {
                ventilador.AddRelativeTorque(0, 300, 0);
                ventilador2.AddRelativeTorque(0, 300, 0);
                //static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
                ligado = true;
            }
            else
            {
                ventilador.AddRelativeTorque(0, -150, 0);
                ventilador2.AddRelativeTorque(0, -150, 0);
                ventilador.AddRelativeTorque(0, 0, 0);
                ventilador2.AddRelativeTorque(0, 0, 0);
                ventilador.AddRelativeTorque(0, -50, 0);
                ventilador2.AddRelativeTorque(0, -50, 0);
                ventilador.AddRelativeTorque(0, 0, 0);
                ventilador2.AddRelativeTorque(0, 0, 0);
                ligado = false;
            }
        }
    }

}
