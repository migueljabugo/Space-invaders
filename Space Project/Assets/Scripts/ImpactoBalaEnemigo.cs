using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//script para actualizar los daños de la nave

public class ImpactoBalaEnemigo : MonoBehaviour {
    public GameObject Vida1; //tendrá 3 vidas
    public GameObject Vida2;
    public GameObject Vida3;
    public GameObject Nave;
    public TextMesh gameOver;
    Reiniciar reiniciar;
    public GameObject camara;

    //variables de audio
    public AudioClip sonidoMuerte;
    public AudioClip sonidoGolpe;
    public float Volumen = 1f;


    int i = 0; //variable contador para ir contando los disparos recibidos por la nave

    private void Start()
    {
        reiniciar = FindObjectOfType<Reiniciar>(); //Buscamos el gameObject "Reinicar" para despues indicarle que solo podremos reiniciar cuando muramos o ganemos

    }

    private void OnCollisionEnter2D(Collision2D collision) //metodo para detectar las colisiones de la nave
    {

        
        if (i < 2) 
        {
            if(i == 0) // si recibimos el primer golpe...
            {
                GameObject.Destroy(Vida1);//quitamos una vida
            }

            if ( i == 1) //si recibimos el segundo golpe...
            {
                GameObject.Destroy(Vida2); // quitamos otra vida
            }

            if (sonidoGolpe)
            {
                AudioSource.PlayClipAtPoint(sonidoGolpe, transform.position, Volumen);
            }
            
            GameObject balaEnemigo = collision.gameObject; 
            Rigidbody2D.Destroy(balaEnemigo); //y cada vez que recibamos un golpe, vamos destruyendo las balas enemigas
            i++;
        } else //y cuando recibamos el tercer golpe...
        {
            GameObject.Destroy(Vida3); //quitamos la ultima vida
            GameObject balaEnemigo = collision.gameObject;
            Rigidbody2D.Destroy(balaEnemigo); //destruimos la bala enemiga
            Rigidbody2D.Destroy(Nave); //destruimos la nave
            Time.timeScale = 0; //pausamos el juego
            gameOver.text = "GAME OVER"; //ponemos por pantalla "Game Over"
            reiniciar.reiniciar = true; //Activamos que se pueda reiniciar
            if (sonidoMuerte) // y si hay sonido añadido...
            {
                AudioSource.PlayClipAtPoint(sonidoMuerte, transform.position, Volumen); //reproducimos el sonido de la cabra gritando
            }
            camara.GetComponent<AudioSource>().mute = true;
        }


    }


}
