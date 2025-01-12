using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Mute_WL : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource music_src;
    public AudioClip music_clp;
    public static bool GameIsPaused = false;


    void Start()
    {
        music_src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.cantidadEnemigos == 0)
        {


            music_src.mute = true;



        }

        if (GameController.M_V == 1)
        {

            music_src.mute = true;


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
            music_src.mute = true;
            GameIsPaused = true;

        }

        void Resume()
        {
            music_src.mute = false;
            GameIsPaused = false;
        }
    }
}

