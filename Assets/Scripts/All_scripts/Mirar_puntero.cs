using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirar_puntero : MonoBehaviour
{

    Camera camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Input.mousePosition - camara.WorldToScreenPoint(transform.position);
        float ang = Vector2.SignedAngle(Vector2.up, dir);
        transform.rotation = (Quaternion.AngleAxis(ang, Vector3.forward));
    }
}
