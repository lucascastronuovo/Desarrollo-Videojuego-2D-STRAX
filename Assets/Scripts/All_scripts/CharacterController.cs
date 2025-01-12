using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        procesarMovimiento();
    }


    void procesarMovimiento ()
    {
        //Logica de Movimiento

        float inputMovimiento_H = Input.GetAxis("Horizontal");
        float inputMovimiento_V = Input.GetAxis("Vertical");

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(inputMovimiento_H * velocidad,  inputMovimiento_V * velocidad);


    }

   


   
}
