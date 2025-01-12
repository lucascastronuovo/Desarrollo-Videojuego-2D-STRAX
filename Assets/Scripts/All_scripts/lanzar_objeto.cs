using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzar_objeto : MonoBehaviour
{
    public Transform firePoint;
    public GameObject objeto;


   




    public float fuerza_disparo = 20f;

    


    

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Q) && GetComponent<Inventario>().Cantidad == 1)
        {


            
            Disparar(objeto);

            GetComponent<Inventario>().Cantidad = GetComponent<Inventario>().Cantidad - 1;

          






        }

        

        void Disparar(GameObject prefab)
        {

            GameObject bala = Instantiate(prefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * fuerza_disparo, ForceMode2D.Impulse);


        }


    }
}
