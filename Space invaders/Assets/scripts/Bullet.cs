using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    //DECLARAMOS LAS VARIABLES PARA LA BALA QUE SALE DEL PLAYER.
    private Transform bullet;
    public float speed;
	public float limite = 5;
	bool fire = false;
	
	void Start () {
        //USAMOS EL COMPONENTE TRANSFORM DE LA BALA.
        bullet = GetComponent<Transform>();
	}
	
	
	void FixedUpdate () {
        //AÑADIMOS LA DIRECCION A LA QUE SE MOVERA LA BALA, 
        //USANDO LA VELOCIDAD QUE AÑADIMOS EN EL FLOAT speed.
		if (Input.GetButton("Fire")) {
			fire = true;
		}
		if (fire) {
			bullet.position += Vector3.up * speed;
			if (bullet.position.y >= limite) {
				Destroy (gameObject);
			}
		}
    
     
	}

    //private void OnTriggerEnter2D(Collider2D enemy)
    //{
    //    if (enemy.tag == "Enemy") 
    //    {
    //        Destroy(enemy.gameObject);
    //        Destroy(gameObject);
    //    }
    //    else if (enemy.tag == "boss")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
