using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Método que atiende al botón
    public void Jugar()
    {
        // CAMBIAR a la escena 'EscenaMapa'
        SceneManager.LoadScene("EscenaMapa");
    }

    // Termina la aplicación
    public void Salir()
    {
        Application.Quit();     // SO
    }
}
