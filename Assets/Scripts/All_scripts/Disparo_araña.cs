using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_araña : MonoBehaviour
{

    public GameObject bala_prefab_A;
    public GameObject caparazon;
    public Transform firePoint_A;
    public float fuerza_disparo_A = 20f;
    public float seg_lanzador_min_A;
    public float seg_lanzador_max_A;



   
    

    void Start()
    {
        StartCoroutine(Disparar_A());
        


    }

    // Update is called once per frame
    void Update()
    {

        if (AnimationManager.corriendo_i == 1)
        {
            bala_prefab_A.gameObject.SetActive(false);
            caparazon.gameObject.SetActive(false);
        }
        else if (AnimationManager.corriendo_i == 0)
        {
            bala_prefab_A.gameObject.SetActive(true);
            caparazon.gameObject.SetActive(true);
        }


    }



    IEnumerator Disparar_A()
    {
        float pausa = Random.Range(seg_lanzador_min_A, seg_lanzador_max_A);
        yield return new WaitForSeconds(pausa);
        Accion_Disparar_A();
    }


    void Accion_Disparar_A()
    {

        GameObject bala = Instantiate(bala_prefab_A, firePoint_A.position, firePoint_A.rotation);
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint_A.up * fuerza_disparo_A, ForceMode2D.Impulse);

        StartCoroutine(Disparar_A());


    }
}
