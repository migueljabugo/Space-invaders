using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImpactoBalaEnemigo : MonoBehaviour {
    public GameObject Vida1;
    public GameObject Vida2;
    public GameObject Vida3;
    public GameObject Nave;
    public TextMesh gameOver;
    
    int i = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (i < 2)
        {
            if(i == 0)
            {
                GameObject.Destroy(Vida1);
            }

            if ( i == 1)
            {
                GameObject.Destroy(Vida2);
            }

            
            
            
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo);
            i++;
        } else
        {
            GameObject.Destroy(Vida3);
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo);
            Rigidbody2D.Destroy(Nave);
            Time.timeScale = 0;
            gameOver.text = "GAME OVER";
            
        }


    }


}
