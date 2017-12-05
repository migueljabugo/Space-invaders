using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para mover la nave y disparar

public class PlayerMovement : MonoBehaviour {
    //DECLARAMOS LAS VARIABLES PUBLICAS, INCLUYENDO LOS LIMITES DE PANTALLA
    //Y EL RATIO DE DISPARO.
    private Transform Player;
    public float speed;
    public float maxBound, minBound; //los limites

    public GameObject shot; //bala de la nave
  
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    //variables de audio
    public AudioClip audioDisparo;
    public float volumen = 1f;
   
    

	void Start () {
        //USAMOS EL TRANSFORM DE La NAVE LLAMADO PLAYER
        Player = GetComponent<Transform>();
        
       
	}
	

	void FixedUpdate () {
        //SE CONFIGURA EL MOVIMIENTO DEL PLAYER USANDO EL AXIS HORIZONTAL Y
        //Y LOS LIMITES DE PANTALLA.
        float h = Input.GetAxis("Horizontal");

        if (Player.position.x < minBound && h < 0) //si la posicion es menor que el limite izquierdo y estemos pulsando para la izquierda...
        {
            h = 0; //paramos la nave
        }
        else if (Player.position.x > maxBound && h > 0) // viceversa
        {
            h = 0;
        }

        Player.position += Vector3.right * h * speed; //movemos la nave en el eje x a una velocidad determinada y con la "h" le damos el sentido.

        
       
    }

    private void Update()
    {
        if (Input.GetButton("Jump") && Time.time > nextFire) //si pulsamos el boton "space" y si el tiempo es mayor que el siguiente disparo.
        {
            if (audioDisparo) //si hay un audio añadido...
            {
                AudioSource.PlayClipAtPoint(audioDisparo, transform.position, volumen);//reproducimos sonido de disparo.
            }
            
            nextFire = Time.time + fireRate; //controlamos que no se pueda disparar seguidamente
            
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); //creamos instancia del prefab balaNave en la posicion y rotacion del spawn, situado en la nave

            DisparoNave disparo = shot.GetComponent<DisparoNave>(); //accedemos al script DisparoNave
            disparo.disparar = false;//y ponemos la variable "disparar" en false para que la bala salga con la fuerza necesaria descrita en dicho script



        }
    }
}
