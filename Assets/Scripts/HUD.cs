using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Controlador del HUD en la escena
 * Autor: Roberto Mtz. Román
 */
public class HUD : MonoBehaviour
{
    public Image imagen1;
    public Image imagen2;
    public Image imagen3;

    public Text textoMonedas;

    public static HUD instance;

    private void Awake()
    {
        instance = this;
    }

    // Deshabilita los corazones dependiendo de las vidas
    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        if (vidas==2)
        {
            imagen3.enabled = false;
        } else if (vidas == 1)
        {
            imagen2.enabled = false;
        } else if (vidas==0)
        {
            imagen1.enabled = false;
        }
    }

    public void ActualizarMonedas()
    {
        textoMonedas.text = SaludPersonaje.instance.monedas.ToString();
    }
}




