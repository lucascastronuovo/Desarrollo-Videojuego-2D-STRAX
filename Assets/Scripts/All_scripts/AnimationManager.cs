using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animator anim;

    public int tiempoCorriendo;
    public int tiempoQuieto;
    public float speed;
    public float stop;
    public static bool corriendo = true;
    public static int corriendo_i;
 



    void Start()
    {
        speed = GetComponent<Enemigo_araña>().moveSpeed;
        anim.SetInteger("Run", 150);
       

    }

    // Update is called once per frame
    void Update()
    {


        Idle();
        




    }


    public void Idle()
    {
        if (corriendo == true) 
        {
            StartCoroutine(Parar());
            corriendo_i = 0;
        }

        else if (corriendo == false)
        {
            StartCoroutine(Correr());
            corriendo_i = 1;
        }
    }

  
    public IEnumerator Parar()
    {
        yield return new WaitForSeconds(8);
        anim.SetInteger("Run", 10);
        GetComponent<Enemigo_araña>().moveSpeed = 0f;
        corriendo = false;
        
    }

    public IEnumerator Correr()
    {
        yield return new WaitForSeconds(10);
        anim.SetInteger("Run", 150);
        GetComponent<Enemigo_araña>().moveSpeed = speed;
        corriendo = true;
        
        
    }

   
}
