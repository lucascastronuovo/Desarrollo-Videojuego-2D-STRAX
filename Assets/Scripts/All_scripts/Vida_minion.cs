using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_minion : MonoBehaviour
{
    public int Vida_m;
    private int vida_max_m;
    public GameObject enemigo_m;
   public GameObject effect_m;
    


    [Header("Prefabs sonidos")]

    public GameObject zombie_dead;




    void Start()
    {
        vida_max_m = Vida_m;
    }

    // Update is called once per frame
    void Update()
    {

       

       


        if (Vida_m <= 0)
        {
            Instantiate(effect_m, transform.position, Quaternion.identity);
            NuevoSonido(zombie_dead, transform.position, 5f);
            Destroy(enemigo_m);
           


        }


    }

   

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
