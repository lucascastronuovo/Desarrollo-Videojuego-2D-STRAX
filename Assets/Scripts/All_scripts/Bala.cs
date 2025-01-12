using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    

    public GameObject hitt_effect;

    [Header("Prefabs sonidos")]

    public GameObject col_mueble;

    void OnCollisionEnter2D(Collision2D collision)
    {

        NuevoSonido(col_mueble, transform.position, 2f);
        GameObject effect = Instantiate(hitt_effect, transform.position, Quaternion.identity);
        Destroy(effect, 0.12f);
        Destroy(gameObject);

       

    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }


}
