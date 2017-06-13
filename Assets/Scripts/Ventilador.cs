using UnityEngine;
using UnityEngine.UI;

public class Ventilador : MonoBehaviour {
    public Text mensagem;
    public Rigidbody ventilador;
    //public Rigidbody ventilador2;
    private bool ligado = false;
    [Range(0.1f, 10.0f)]
    public float distancia = 1.3f;
    private GameObject Jogador;

    void Start()
    {        
        Jogador = GameObject.FindWithTag("Player");
   }

   // void OnTriggerEnter(Collider other)
   void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, Jogador.transform.position) < distancia)
      //  {
       //     mensagem.text = "Click para ligar o ventilador";
     //   }

   //     if (Input.GetMouseButton(0))
            {
            mensagem.text = "Click para ligar o ventilador";
            if (ligado == false)
                {
                    ventilador.AddRelativeTorque(0, 300, 0);
                   // ventilador2.AddRelativeTorque(0, 300, 0);
                    //static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
                    ligado = true;
                }
                else
                {
                    ventilador.AddRelativeTorque(0, -150, 0);
                  //  ventilador2.AddRelativeTorque(0, -150, 0);
                    ventilador.AddRelativeTorque(0, 0, 0);
                 //   ventilador2.AddRelativeTorque(0, 0, 0);
                    ventilador.AddRelativeTorque(0, -50, 0);
                  //  ventilador2.AddRelativeTorque(0, -50, 0);
                    ventilador.AddRelativeTorque(0, 0, 0);
                //    ventilador2.AddRelativeTorque(0, 0, 0);
                    ligado = false;
                }
            }
          else
            {
               mensagem.text = "    ";
           }

    }

}
