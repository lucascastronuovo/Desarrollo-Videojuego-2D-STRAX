using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cant_balaverde : MonoBehaviour
{
    public int cant_bv = 0;

    public Cant_mueble C_m;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && cant_bv == 0 && C_m.cant_m == 0)
        {
            cant_bv = cant_bv + 1;
            Destroy(other.gameObject);
        }
    }

}
