using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateInvaders : MonoBehaviour {

	public GameObject invader;
	public float separationVertical=1;
	public float separationHorizontal=1;
	public int rows = 5;
	public int colums=11;

    
	void Start () {
		//Recoger la posición inicial de los invaders
		float posVert = transform.position.y;
		float posHor = transform.position.x;


		for (int x = 0; x < colums; x++) {
			//Colocando fila x
			GameObject enemigoPorDebajo = null;

			for (int y = rows; y > 0; y--) {
				//Coloca columna y
				GameObject enemy = GameObject.Instantiate (invader); 

				enemy.GetComponent<ReferenciaEnemigo> ().enemigoPorDebajo = enemigoPorDebajo;
				Debug.Log ("Enemigo por debajo: "+(enemy.GetComponent<ReferenciaEnemigo> ().enemigoPorDebajo!=null?"si":"no"));
				enemigoPorDebajo = enemy.gameObject;

				enemy.transform.parent = this.gameObject.transform;
				enemy.transform.position = new Vector2 (posHor + x, posVert - y);


				posVert += separationVertical;
			}

			posHor += separationHorizontal;
			posVert = transform.position.y;
		}
	}
}
