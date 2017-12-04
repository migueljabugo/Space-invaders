using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : MonoBehaviour {

    public TextMesh myText; // 9º --> Accedemos al TextMesh del GameObject
	
	public void SetScore(int score) // 10º --> metodo para construir un string
    {
        string scoreText = "Score: " + score; //11º --> Ponemos este formato, que se vera por pantalla.
        myText.text = scoreText; //12º --> y en el componente "Text" añadimos nuestra variable "scoreText"
    }
}
