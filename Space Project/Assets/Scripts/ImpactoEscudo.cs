using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoEscudo : MonoBehaviour {

    public GameObject escudo;
    int i = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (i <= 2)
        {
            if(i == 0)
            {
                escudo.transform.localScale = new Vector3(4f, 2f, 0);
            }
            if( i == 1)
            {
                escudo.transform.localScale = new Vector3(2f, 1f, 0);
            }
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo);

            
            i++;
        } else
        {
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo);
            Rigidbody2D.Destroy(escudo);
        }
    }

   
}
