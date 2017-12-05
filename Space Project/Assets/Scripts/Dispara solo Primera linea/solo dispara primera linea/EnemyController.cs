using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//script para controlar el movimiento y disparo de los marcianos.

public class EnemyController : MonoBehaviour {

	private Transform enemyHolder;
	public float speed;
   

	public GameObject shot; //bala enemigo
	
	public float fireRate = 0.997f; //ratio de disparo

    public TextMesh gameOver;

    public GameObject camara;

    Reiniciar reiniciar;

    //variables de audio
    public AudioClip sonidoDisparoEnemigo;
    public AudioClip sonidoVictoria;
    public AudioClip sonidoCabra;
    public float volumen = 1f;

	
	void Start () {
		
        
		InvokeRepeating ("MoveEnemy", 0.1f, 0.3f); //Llamamos al metodo "moveEnemy" de abajo y decimos que en un tiempo de 0,1 se repita el metodo 0,3 veces.
		enemyHolder = GetComponent<Transform> (); //accedemos al transform del objeto "enemyHolder" que contendrá todos los marcianos generados
        reiniciar = FindObjectOfType<Reiniciar>();
    }

	void MoveEnemy() //metodo para mover los marcianos y disparar
	{
		enemyHolder.position += Vector3.right * speed; //vamos moviendo los marcianos en el eje x a una determinada velocidad.

		foreach (Transform enemy in enemyHolder) { //recorremos cada marciano de enemyHolder
			if (enemy.position.x < -10.5 || enemy.position.x > 10.5) { //cuando haya un marciano que supere estos limites en el eje x...
				speed = -speed; //le cambiamos el sentido
				enemyHolder.position += Vector3.down * 0.5f; //lo bajamos una posicion en el eje Y
				return;
			}


			//para que solo dispare las primeras lineas...
			if (Random.value > fireRate) {	//de forma aleatoria	
				Debug.Log ("ReferenciaEnemigo "+enemy.gameObject.GetComponent<ReferenciaEnemigo>()); 	
				if (enemy.gameObject.GetComponent<ReferenciaEnemigo>().enemigoPorDebajo == null) {
					Debug.Log ("Dispara");

                    Instantiate (shot, enemy.position, enemy.rotation); //creamos instancias de balas enemigas en la posicion de dicho enemigo
                    if (sonidoDisparoEnemigo)
                    {
                        AudioSource.PlayClipAtPoint(sonidoDisparoEnemigo, transform.position, volumen);
                    }
                }

			}


            if (enemy.position.y <= -2) //si la posicion de los marcianos llegan a -2 en el eje y...
            {
                gameOver.text = "GAME OVER"; //Game Over
                Time.timeScale = 0;//pausamos el juego
                if (sonidoCabra)
                {
                    AudioSource.PlayClipAtPoint(sonidoCabra, transform.position, volumen);
                }
                reiniciar.reiniciar = true;
            }
        } //dejamos de recorrer los marcianos.
       
        

        if (enemyHolder.childCount == 1) { //cuando quede solo 1 marcianos...
            
            CancelInvoke (); //cancelamos el invokeRepeating
			InvokeRepeating ("MoveEnemy", 0.1f, 0.25f); //y decimos que se repita el metodo mas rapido.
		}

		if (enemyHolder.childCount == 0) { //cuando no queden marcianos...
            Time.timeScale = 0; // pausamos
            gameOver.text = "Winner!!!"; //Winner
            camara.GetComponent<AudioSource>().mute = true;
            if (sonidoVictoria)
            {
                AudioSource.PlayClipAtPoint(sonidoVictoria,transform.position,volumen);
            }
            reiniciar.reiniciar = true;
        }

        
	}
    
}
