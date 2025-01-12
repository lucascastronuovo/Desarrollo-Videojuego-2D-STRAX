using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_enem_lanzador : MonoBehaviour
{
    
    public GameObject bala_prefab;
    public Transform firePoint;
    public float fuerza_disparo = 20f;
    public float seg_lanzador_min;
    public float seg_lanzador_max;

    void Start()
    {
        StartCoroutine(Disparar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator Disparar()
    {
        float pausa = Random.Range(seg_lanzador_min,seg_lanzador_max);
        yield return new WaitForSeconds(pausa);
        Accion_Disparar();
    }


    void Accion_Disparar()
    {

        GameObject bala = Instantiate(bala_prefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fuerza_disparo, ForceMode2D.Impulse);

        StartCoroutine(Disparar());


    }
}
