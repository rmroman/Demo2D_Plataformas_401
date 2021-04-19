using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image imagenFondo;

    // Método que atiende al botón
    public void Jugar()
    {
        // Habilitar la imagen
        imagenFondo.gameObject.SetActive(true);
        imagenFondo.canvasRenderer.SetAlpha(0);
        imagenFondo.CrossFadeAlpha(1, 0.7f, false);

        StartCoroutine(CargarEscena());

        // CAMBIAR a la escena 'EscenaMapa'
        //SceneManager.LoadScene("EscenaMapa");
    }

    private IEnumerator CargarEscena()
    {
        yield return new WaitForSeconds(0.7f);
        // Regresó (después de 3 segundos)
        SceneManager.LoadScene("EscenaMapa");
    }

    // Termina la aplicación
    public void Salir()
    {
        Application.Quit();     // SO
    }
}
