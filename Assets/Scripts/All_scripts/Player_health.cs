using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_health : MonoBehaviour
{


    [Header("Personaje")]
    public GameObject personaje;
    public float HP_Min;
    public float HP_Max;
    public Image barra;
    public int dead;
    public GameObject effect;

    [Header("Prefabs sonidos")]

    public GameObject strax_dead;

   


    void Start()
    {
        personaje.gameObject.SetActive(true);
        
    }


    private void Update()
    {
        
        Vida();

        if (HP_Min <= 0)
        {
            
            Die();
            GameController.M_V = 1;
            
            
        }

        if (HP_Min > HP_Max)
        {
            HP_Min = HP_Max;
        }
    }

    // Update is called once per frame
   


    void Die()
    {
        NuevoSonido(strax_dead, transform.position, 5f);
        //Destroy(gameObject);
        personaje.gameObject.SetActive(false);
        Instantiate(effect, transform.position, Quaternion.identity);
        dead++;
        
    }

   

    public void Vida()
    {
        barra.fillAmount = HP_Min / HP_Max;
    }

    void NuevoSonido(GameObject prefab, Vector2 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }

    

}
