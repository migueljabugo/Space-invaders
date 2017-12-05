﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

	private Transform enemyHolder;
	public float speed;
    //public Transform Nave;

	public GameObject shot;
	
	public float fireRate = 0.997f;

    public TextMesh gameOver;

	// Use this for initialization
	void Start () {
		//winText.enabled = false;
        
		InvokeRepeating ("MoveEnemy", 0.1f, 0.3f);
		enemyHolder = GetComponent<Transform> ();
	}

	void MoveEnemy()
	{
		enemyHolder.position += Vector3.right * speed;

		foreach (Transform enemy in enemyHolder) {
			if (enemy.position.x < -10.5 || enemy.position.x > 10.5) {
				speed = -speed;
				enemyHolder.position += Vector3.down * 0.5f;
				return;
			}


			//EnemyBulletController called too?
			if (Random.value > fireRate) {		
				Debug.Log ("ReferenciaEnemigo "+enemy.gameObject.GetComponent<ReferenciaEnemigo>());	
				if (enemy.gameObject.GetComponent<ReferenciaEnemigo>().enemigoPorDebajo == null) {
					Debug.Log ("Dispara");
					Instantiate (shot, enemy.position, enemy.rotation);
				}

			}


            if (enemy.position.y <= -2)
            {
                gameOver.text = "GAME OVER";
                Time.timeScale = 0;
            }
        }
       
        

        if (enemyHolder.childCount == 1) {
            
            CancelInvoke ();
			InvokeRepeating ("MoveEnemy", 0.1f, 0.25f);
		}

		if (enemyHolder.childCount == 0) {
            Time.timeScale = 0;
            gameOver.text = "Winner!!!";
		}

        
	}
    
}
