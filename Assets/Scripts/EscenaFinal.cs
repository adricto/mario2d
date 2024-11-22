using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaFinal : MonoBehaviour
{
    public TextMeshProUGUI textoGanador;

    void Start()
    {
        
    }

    public void volverJugar()
    {

        SceneManager.LoadScene("Escena1");
    }
}
