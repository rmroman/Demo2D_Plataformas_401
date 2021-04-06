using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Control de la salud del personaje (vidas)
*/
public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;
    public int monedas = 0;

    public static SaludPersonaje instance;
    
    // Cuando se activa el objeto
    private void Awake()
    {
        instance = this;
    }
}
