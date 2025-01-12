using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_araña : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed = 5f;
    private float speed;
    private bool corriendo = true;
   



    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        speed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        movimiento_ara();
        Invoke("Stop", 8);
       
        Invoke("Run", 10);


    }

    private void FixedUpdate()
    {
        MoveEnem(movement);
    }
    private void MoveEnem(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        


    }

    void movimiento_ara()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

    }

    public void Idle()
    {
        if (corriendo == true)
        {
            StartCoroutine(Parar());
        }

        else if (corriendo == false)
        {
            StartCoroutine(Correr());
        }
    }

    public void Stop()
    {
        moveSpeed = 0f;
    }

    public void Run()
    {
        moveSpeed = speed;
    }

    public IEnumerator Parar()
    {
        yield return new WaitForSeconds(8);
        moveSpeed = 0f;
        corriendo = false;
    }

    public IEnumerator Correr()
    {
        
        yield return new WaitForSeconds(10);
        moveSpeed = speed;
        corriendo = true;

    }

    
}
