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
		for (int y = 0; y < rows; y++) {
			//Coloca columna y
			for (int x = 0; x < colums; x++) {
				//Colocando fila x
				GameObject cube = GameObject.Instantiate (invader); 
				cube.transform.parent = this.gameObject.transform;
				cube.transform.position = new Vector2 (posHor + x, posVert - y);
				posHor += separationHorizontal;
			}
			posHor = transform.position.x;
			posVert -= separationVertical;
		}
	}
}
