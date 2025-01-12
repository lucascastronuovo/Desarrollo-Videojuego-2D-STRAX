using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_enem : MonoBehaviour
{

    public int damage;
    public GameObject effect;

    [Header("Prefabs sonidos")]
    public GameObject strax_damaged;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            if (coll.GetComponent<Player_health>().HP_Min > 0)
            {
                NuevoSonido(strax_damaged, transform.position, 2f);
                coll.GetComponent<Player_health>().HP_Min -= damage;
                Instantiate(effect, transform.position, Quaternion.identity);


                
            }
        }
    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }

}
