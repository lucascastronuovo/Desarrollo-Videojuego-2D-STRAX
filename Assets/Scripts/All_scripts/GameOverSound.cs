using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource GO_src;
    public AudioClip GO_clp;
    private float tiempoG1;
    public float tiempoG;
    public GameObject GOObj;
    void Start()
    {
        GO_src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.M_V == 0 && Time.time > tiempoG1)
        {

            tiempoG1 = Time.time + tiempoG;
            NuevoSonido(GOObj, transform.position, 10f);
            GO_src.Stop();





        }
    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
