using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{

    [SerializeField] private GameObject FinalBattleScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        FinalBattleScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void goToTheBattle()
    {
        Time.timeScale = 1f;
        FinalBattleScreen.SetActive(false);
    }

}
