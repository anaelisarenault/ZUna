using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarAndar : MonoBehaviour {
    public int fase;

    void OnTriggerEnter(Collider other)
    {

        if (fase == 1)
        {
            SceneManager.LoadScene("Andar 1");
        }
        else if (fase == 2)
        {
            SceneManager.LoadScene("Andar 2");
        }

    }
}
