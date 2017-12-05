using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para ir destruyendo las balas enemigas cuando salgan de pantalla.

public class ZonaMuertaInferior : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) // con un trigguer en la parte inferior
    {
        GameObject balaEnemigo = collision.gameObject;
        Rigidbody2D.Destroy(balaEnemigo);
    }

}
