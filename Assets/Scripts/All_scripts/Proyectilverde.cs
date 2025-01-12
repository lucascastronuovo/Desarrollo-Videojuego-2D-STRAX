using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectilverde : MonoBehaviour
{
    public GameObject proyectil;
    public int cantProyectil = 0;
    


    public Transform firePoint;
    
    public float fuerza_disparo = 20f;


    


   
    public void Start()
    {
       
    }

     public void Update()
    {
        if (cantProyectil == 1 && Input.GetKey(KeyCode.Q))
        {
            Disparar();
        }
    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }


    void Disparar()
    {

        GameObject bala = Instantiate(proyectil, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fuerza_disparo, ForceMode2D.Impulse);


    }
}
