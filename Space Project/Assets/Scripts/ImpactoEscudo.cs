using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para actualizar los daños de los escudos

public class ImpactoEscudo : MonoBehaviour {

    public GameObject escudo;
    int i = 0; //variable contador

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (i < 2)
        {
            if(i == 0) //si recibe el primer golpe...
            {
                escudo.transform.localScale = new Vector3(4f, 2f, 0); //escalamos el escudo a un tamaño menor
            }
            if( i == 1) //si recibe el segundo golpe...
            {
                escudo.transform.localScale = new Vector3(2f, 1f, 0); //lo volvemos a escalar a un tamaño menor
            }
            GameObject balaEnemigo = collision.gameObject; 
            Rigidbody2D.Destroy(balaEnemigo); //cada vez que reciba un golpe los escudos, destruimos las balas enemigas.

            
            i++;
        } else // y si recibe el tercer golpe...
        {
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo);
            Rigidbody2D.Destroy(escudo);
        }
    }

   
}
