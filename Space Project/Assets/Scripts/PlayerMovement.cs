using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour {
    //DECLARAMOS LAS VARIABLES PUBLICAS, INCLUYENDO LOS LIMITES DE PANTALLA
    //Y EL RATIO DE DISPARO.
    private Transform Player;
    public float speed;
    public float maxBound, minBound;

    public GameObject shot;
  
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    Vector2 direccion;
    //public float speedShot;

	void Start () {
        //USAMOS EL TRANSFORM DEL CUBO LLAMADO PLAYER
        Player = GetComponent<Transform>();
        direccion = transform.up;
       
	}
	

	void FixedUpdate () {
        //SE CONFIGURA EL MOVIMIENTO DEL PLAYER USANDO EL AXIS HORIZONTAL Y
        //Y LOS LIMITES DE PANTALLA.
        float h = Input.GetAxis("Horizontal");

        if (Player.position.x < minBound && h < 0)
        {
            h = 0;
        }
        else if (Player.position.x > maxBound && h > 0)
        {
            h = 0;
        }

        Player.position += Vector3.right * h * speed;

        
       
    }

    private void Update()
    {
        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            DisparoNave disparo = shot.GetComponent<DisparoNave>();
            disparo.disparar = false;



        }
    }
}
