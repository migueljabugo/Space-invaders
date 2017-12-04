using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour {

    public Rigidbody2D myRigidbody;
    Vector2 direccion;
    public float fuerzaLanzamiento;
    public bool disparar;

    void Start () {
        direccion = -transform.up;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector2 fuerza = direccion * fuerzaLanzamiento;




        if (!disparar) { 
            myRigidbody.AddForce(fuerza);

            disparar = true;
            myRigidbody.velocity = Vector2.zero;

        }



    }
}
