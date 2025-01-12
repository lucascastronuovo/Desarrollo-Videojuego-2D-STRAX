using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Contador de enemigos")]

    public static int cantidadEnemigos;
    public int Cuantos_enem;

    [Header("Muerto 1 Vivo 0")]

    public static int M_V = 0;
    

    void Start()
    {


        M_V = 0;
        cantidadEnemigos = Cuantos_enem;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
