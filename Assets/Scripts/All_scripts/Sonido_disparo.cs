using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_disparo : MonoBehaviour
{

    public AudioSource sonido;
    public AudioClip clip;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            Reproducir();



        }

        if (Input.GetMouseButtonUp(0))
        {


            sonido.Stop();



        }

        if (GameController.cantidadEnemigos == 0)
        {

            sonido.Stop();





        }
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


    }


    public void Reproducir()
    {

        sonido.Play();

    }


}
