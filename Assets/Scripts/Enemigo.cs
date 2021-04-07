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
    public AudioSource efectoChocaPersonaje;
    public AudioSource efectoMuerePersonaje;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Repriducir el sonido
            efectoChocaPersonaje.Play();

            SaludPersonaje.instance.vidas--; // Descuenta una vida
            // Actualizar el HUD
            HUD.instance.ActualizarVidas();
            
            if (SaludPersonaje.instance.vidas == 0)
            {
                efectoMuerePersonaje.Play();
                Destroy(other.gameObject, 5f);
                

                //SceneManager.LoadScene("EscenaMenu");
            }
        }
    }
}
