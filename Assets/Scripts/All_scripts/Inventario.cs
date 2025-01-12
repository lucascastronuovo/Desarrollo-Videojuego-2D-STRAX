using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Inventario : MonoBehaviour
{
    public int Cantidad = 0;
    public string tipo;
    public GameObject OBJ;
    public GameObject OBJ_M;



    void Start()
    {


        OBJ.SetActive(false);
        OBJ_M.SetActive(false);




    }
    void Update()
    {

        if (Cantidad == 1)
        {
            OBJ.SetActive(true);
            OBJ_M.SetActive(true);
        }
        else if (Cantidad == 0)
        {
            OBJ.SetActive(false);
            OBJ_M.SetActive(false);
        }




    }



}
