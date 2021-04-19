using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Mover el proyectil horizontalmente
 */
public class Proyectil : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer rendererProyectil;

    private float velocidadX = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rendererProyectil = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocidadX, 0);
    }
    
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward, 5);
        // Revisar cuándo debe desaparecer
        if (!rendererProyectil.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
