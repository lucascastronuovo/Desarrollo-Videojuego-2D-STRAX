using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    [SerializeField] private GameObject PauseScreen;

    public static bool GameIsPaused = false;

    void Start()
    {
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
        GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
            
        }

        void Pause ()
        {
            Time.timeScale = 0f;
            PauseScreen.SetActive(true);
            GameIsPaused = true;
        }

        void Resume()
        {
            Time.timeScale = 1f;
            PauseScreen.SetActive(false);
            GameIsPaused = false;
        }

    }
    

}
