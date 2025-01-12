using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLvlSound : MonoBehaviour
{

    public AudioSource WinSoundsrc;
    public AudioClip WinSoundclp;
    private float tiempo1;
    public float tiempo;
    public GameObject WinObj;



    void Start()
    {
        WinSoundsrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.cantidadEnemigos == 0 && Time.time > tiempo1)    
        {

            tiempo1 = Time.time + tiempo;
            NuevoSonido(WinObj, transform.position, 10f);
            WinSoundsrc.Stop();
            
            



        }
    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
