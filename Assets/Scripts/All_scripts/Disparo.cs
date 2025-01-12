using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bala_prefab;
    public float fireRate;
    private float nextFire;

   


    public float fuerza_disparo = 20f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {

           
            nextFire = Time.time + fireRate;
            Disparar();

                
            

            

        }


        void Disparar()
        {

           GameObject bala = Instantiate(bala_prefab, firePoint.position ,  firePoint.rotation);
           Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
           rb.AddForce(firePoint.up * fuerza_disparo, ForceMode2D.Impulse);
            

        }

       

    }

    
}
