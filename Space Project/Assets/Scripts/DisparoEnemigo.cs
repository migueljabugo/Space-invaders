using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para darle direccion y fuerza a las balas de los enemigos

public class DisparoEnemigo : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    Vector2 direccion;
    public float fuerzaLanzamiento;
    public bool disparar; 

    void Start()
    {
        direccion = -transform.up;
    }

    
    void FixedUpdate()
    {

        Vector2 fuerza = direccion * fuerzaLanzamiento;




        if (!disparar)
        {
            myRigidbody.AddForce(fuerza);

            disparar = true;
            myRigidbody.velocity = Vector2.zero;

        }



    }
}
