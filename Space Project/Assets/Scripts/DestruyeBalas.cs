using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para destruir las balas cuando choquen entre si.
public class DestruyeBalas : MonoBehaviour {

    public GameObject bala;

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Rigidbody2D.Destroy(bala);
        GameObject balaEnemigo = collision.gameObject;
        Rigidbody2D.Destroy(balaEnemigo);
    }



}
