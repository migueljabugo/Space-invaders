using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour {

    //public Transform spawnPositionBala;
    

    private void OnTriggerEnter2D(Collider2D BalaCollider)
  
    {
        GameObject bala = BalaCollider.gameObject;
        Rigidbody2D.Destroy(bala);
        
        //Movemos la bala a la posicion inicial
        //bala.transform.position = spawnPositionBala.position;

        //ponemos a cero la velocidad
        //Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
        //rb.velocity = Vector2.zero;
        
        //DisparoNave disparo = bala.GetComponent<DisparoNave>();
        //disparo.disparar = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
