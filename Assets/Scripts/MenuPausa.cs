using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Controlador del MenuPausa (Panel)
 * Autor: Roberto Mtz. Román
 */
public class MenuPausa : MonoBehaviour
{
    public bool estaPausado = false;

    public GameObject pantallaPausa;

    public void Pausar()
    {
        estaPausado = !estaPausado; // ????
        pantallaPausa.SetActive(estaPausado);
        
        // Activar/desactivar las actualizaciones
        // if terciario
        Time.timeScale = estaPausado ? 0 : 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
}
