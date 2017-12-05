using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para darle direccion y fuerza a la bala de la nave

public class DisparoNave : MonoBehaviour {

    public Rigidbody2D myRigidbody; //rigidboody de la bala de la nave
    Vector2 direccion;
    public float fuerzaLanzamiento;
    public bool disparar; // con esta variable controlaremos que a la bala solo se aplique la fuerza cuando lo pongamos a true.

    void Start () {
        direccion = -transform.up; // en negativo porque al crearse las instancias de balas, salían para abajo.
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector2 fuerza = direccion * fuerzaLanzamiento; 




        if (!disparar) { 
            myRigidbody.AddForce(fuerza); //añadimos una fuerza a la bala de la nave

            disparar = true;
            myRigidbody.velocity = Vector2.zero; //ponemos la velocidad a cero para cuando volvamos a disparar, parta desde cero.

        }



    }
}
