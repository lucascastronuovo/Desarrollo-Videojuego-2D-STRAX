using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_player : MonoBehaviour
{
    public int damage;
    public GameObject bala;
    public GameObject effect;

    [Header("Prefabs sonidos")]
    public GameObject zombie_damaged;


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            coll.GetComponent<Vida_enemigo>().Vida -= damage;
            NuevoSonido(zombie_damaged, transform.position, 2f);
            coll.GetComponent<Vida_enemigo>().cronometro = 0.5f;
            Instantiate(effect, transform.position, Quaternion.identity);


            Destroy(bala);


        }

        if (coll.CompareTag("Minion"))
        {
            coll.GetComponent<Vida_minion>().Vida_m -= damage;
            NuevoSonido(zombie_damaged, transform.position, 2f);
            Instantiate(effect, transform.position, Quaternion.identity);


            Destroy(bala);


        }

        
    }
    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
