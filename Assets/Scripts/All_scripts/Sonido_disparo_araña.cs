using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_disparo_araña : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip clip;
    public static bool GameIsPaused = false;

    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }


        }
    }
    void Pause()
    {
        sonido.mute = true;
        GameIsPaused = true;

    }

    void Resume()
    {
        sonido.mute = false;
        GameIsPaused = false;
    }






    public void Reproducir()
    {

       sonido.Play();

    

    }

}
