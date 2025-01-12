using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private GameObject WinLevelScreen;

    
   
    





    void Start()
    {
        Time.timeScale = 1f;
        WinLevelScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       

        if (GameController.cantidadEnemigos == 0)
        {
            Time.timeScale = 0f;
            WinLevelScreen.SetActive(true);
           
           
            
            

        }
    }

   
}
