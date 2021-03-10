using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Controla el cambio de animaciones del personaje
 * Autor: Roberto Mtz. Román
 */
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb2D;       // Para la velocidad
    private Animator anim;          // Animator del personaje
    private SpriteRenderer sprRenderer; // Para Flip (vea a la izquierda)
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocidad = Mathf.Abs(rb2D.velocity.x);
        // Idle -> Walk
        anim.SetFloat("velocidad", velocidad);
        
        // Izquierda  <-----> Derecha
        if (rb2D.velocity.x > 0.1)
        {
            sprRenderer.flipX = false;
        } else if (rb2D.velocity.x < -0.1)
        {
            sprRenderer.flipX = true;   // Voltear
        }
        
        // Idle <-> Jump
        if (!PruebaPiso.estaEnPiso)
        {
            anim.SetBool("saltando", true);
        }
        else
        {
            anim.SetBool("saltando", false);
        }
    }
}
