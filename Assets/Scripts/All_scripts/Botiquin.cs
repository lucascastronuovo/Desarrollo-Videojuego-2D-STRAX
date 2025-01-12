using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : MonoBehaviour
{
    public GameObject botiquin;
    public int vida_botiquin;


    [Header("Prefabs sonidos")]

    public GameObject botiquin_sonido;


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            coll.GetComponent<Player_health>().HP_Min += vida_botiquin;
            NuevoSonido(botiquin_sonido, transform.position, 1f);
            Destroy(botiquin);

            
        }


    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
