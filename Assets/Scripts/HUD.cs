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

    public Image imagenFondo;       // Color que hará FadeIn

    

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        // FadeIn
        imagenFondo.canvasRenderer.SetAlpha(1f);
        FadeIn();

        int numeroMonedas = PlayerPrefs.GetInt("numeroMonedas", 3);
        textoMonedas.text = numeroMonedas.ToString();
        SaludPersonaje.instance.monedas = numeroMonedas;
    }

    private void FadeIn()
    {
        imagenFondo.CrossFadeAlpha(0, 0.7f, false);
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




