using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementa UN comportamiento del personaje
public class MoverPersonaje : MonoBehaviour
{
    // VARIABLES
    public float velocidadX = 10;    // Mov. Horizontal (desplazamiento sobre plataforma)
    public float velocidadY = 7;    // Mov. Vertical (salto)

    // Necesito el Rigidbody para cambiar la velocidad
    private Rigidbody2D rigidbody;

    // Prefab para clonar proyectiles
    public GameObject proyectil;        // Arrastar el prefab a esta variable


    // METODOS

    // Start is called before the first frame update
    void Start()
    {
        // Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame (60 veces/s) CONTINUA
    void Update()
    {
        // Probar la entrada de usuario
        float movHorizontal = Input.GetAxis("Horizontal");      // En X

        // Mover el objeto
        rigidbody.velocity = new Vector2( movHorizontal * velocidadX, rigidbody.velocity.y);

        // Mover vertical (SALTO)
        //float movVertical = Input.GetAxis("Vertical");      // [0, 1]
        //if (movVertical > 0 && PruebaPiso.estaEnPiso)
        if ( Input.GetButtonDown("Jump") && PruebaPiso.estaEnPiso )
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, velocidadY);
        }
        // DISPARA!!!!!
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nuevoProyectil = Instantiate(proyectil);
            nuevoProyectil.transform.position = gameObject.transform.position;
            nuevoProyectil.SetActive(true);
        }
    }
}





