using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    // Start is called before the first frame update

    

  


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player" && other.GetComponent<Inventario>().Cantidad == 0)
        {
            other.GetComponent<Inventario>().Cantidad = other.GetComponent<Inventario>().Cantidad + 1;
            
            Destroy(gameObject);

        }
        
    } 
}
