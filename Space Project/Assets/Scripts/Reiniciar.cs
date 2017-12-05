using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//script para reinicar el nivel

public class Reiniciar : MonoBehaviour {

    public TextMesh gameOver;
    public bool reiniciar; //variable booleana para controlar cuando poder reiniciar
	
	
	void Update () {
        if (reiniciar && Input.GetKeyDown(KeyCode.R))  // si la variable booleana es True y pulsamos R
        {
            
                SceneManager.LoadScene("SpaceInvaders"); //cargamos las escena de nuevo
                Time.timeScale = 1; //quitamos la pausa que hubiese
            gameOver.text = ""; //borramos el texto de "Game Over" o "Winner", segun el caso
            reiniciar = false; // y ponemos la variable a false, para controlar que no se pueda reiniciar de nuevo.
        }
	}
}
