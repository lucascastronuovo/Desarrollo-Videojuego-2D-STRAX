using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_mute : MonoBehaviour
{
    public AudioSource z_src;
    public AudioClip z_clp;
    public int Pausado = 0;

    void Start()
    {
        z_src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.M_V == 1)
        {

            z_src.mute = true;


        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Pausado == 1)
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
        z_src.mute = true;
       Pausado = 1;

    }

    void Resume()
    {
        z_src.mute = false;
       Pausado = 0;
    }
}
