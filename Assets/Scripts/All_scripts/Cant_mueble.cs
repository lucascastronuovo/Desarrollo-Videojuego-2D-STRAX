using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cant_mueble : MonoBehaviour
{
    public int cant_m = 0;

    public Cant_balaverde C_bv;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && cant_m == 0 && C_bv.cant_bv == 0)
        {

            cant_m = cant_m + 1;
            Destroy(other.gameObject);
        }
    }
}
