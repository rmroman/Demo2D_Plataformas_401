using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public GameObject personaje;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp( personaje.transform.position.x, 0, 18);
        float y = Mathf.Clamp(personaje.transform.position.y, 0, 4.8f);
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
