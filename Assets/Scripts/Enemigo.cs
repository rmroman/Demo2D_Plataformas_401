using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Controlador del enemigo. Checa la colisión con el personaje
 */
public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SaludPersonaje.instance.vidas--; // Descuenta una vida
            // Actualizar el HUD
            HUD.instance.ActualizarVidas();
            
            if (SaludPersonaje.instance.vidas == 0)
            {
                Destroy(other.gameObject, 0.5f);
                SceneManager.LoadScene("EscenaMenu");
            }
        }
    }
}
