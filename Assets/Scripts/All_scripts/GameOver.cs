using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject GameOverScreen;



    void Start()
    {
        GameOverScreen.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameController.M_V == 1)
        {

            Time.timeScale = 0f;
            GameOverScreen.SetActive(true);


        }



    }

}
    
