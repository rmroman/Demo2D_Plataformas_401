using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Detecta la colisión entre la moneda y el personaje
 */
public class MonedaItem : MonoBehaviour
{
    // Se ejecuta cuando hay una colisión
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Lo debe recolectar
            // PRENDE la explosión
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            // ESCONDE moneda (no la dibuja)
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 1f);    // Lo destruye después de 0.8s
            
            // Desaparece el personaje
            //Destroy(other.gameObject);
        }
    }
}
