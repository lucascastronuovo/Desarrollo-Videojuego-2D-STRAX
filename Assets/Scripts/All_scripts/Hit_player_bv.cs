using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_player_bv : MonoBehaviour
{
    public int damage_bv;
    public GameObject bala_bv;
    public GameObject effect_bv;

    [Header("Prefabs sonidos")]
    public GameObject zombie_damaged_bv;


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            coll.GetComponent<Vida_enemigo>().Vida -= damage_bv;
            NuevoSonido(zombie_damaged_bv, transform.position, 2f);
            coll.GetComponent<Vida_enemigo>().cronometro = 0.5f;
            Instantiate(effect_bv, transform.position, Quaternion.identity);


            Destroy(bala_bv);


        }

        


    }
    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
