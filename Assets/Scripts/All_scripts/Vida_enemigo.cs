using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vida_enemigo : MonoBehaviour
{
    public int Vida;
    private int vida_max;
    public GameObject enemigo;
    public SpriteRenderer[] spr;
    public float tiempo_brillo;
    public bool cambio;
    public Color[] color_;
    public float speed_shine;
    public float cronometro;
    public GameObject effect;
    public Slider barraVida_boss;
   

    [Header("Prefabs sonidos")]
    
    public GameObject zombie_dead;


    

    void Start()
    {
        vida_max = Vida;
    }

    // Update is called once per frame
    void Update()
    {
        
       

        Brillo();
        

        if (Vida <= 0)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            NuevoSonido(zombie_dead, transform.position, 5f);
            Destroy(enemigo);
            GameController.cantidadEnemigos--;           
           
            
        }

        barraVida_boss.value = Vida;

    }

    public void Brillo()
    {

        if (cronometro > 0)
        {
            cronometro -= 1 * Time.deltaTime;
            spr[1].sprite = spr[0].sprite;
            tiempo_brillo += speed_shine * Time.deltaTime;


            switch (cambio)
            {
                case true:
                    spr[1].color = color_[0];
                    break;

                case false:
                    spr[1].color = color_[1];
                    break;


            }

            if (tiempo_brillo > 1)
            {
                cambio = !cambio;
                tiempo_brillo = 0;
            }
        }
        else
        {

            cronometro = 0;
            spr[1].color = color_[0];
        }
    }

   
    void NuevoSonido (GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }

}
