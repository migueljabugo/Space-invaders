using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public int currentScore; // 3º --> Puntuacion actual
    public ScoreText scoreText; // 13º --> referencia para pasarle el scripts "ScoreText"
    

    private void Start()
    {
        ResetScore(); // para no repetir codigo

    }
    public void AddScore(int score) // 4º --> metodo para añadir la puntuacion que reciba
    {
        currentScore += score; // 5º --> vamos guardando en la puntuacion actual las puntuaciones
        scoreText.SetScore(currentScore); //14º --> Al metodo "SetScore" del gameobject ScoreText le añadimos la puntuacion actual que se irá viendo por pantalla
    }


    public void ResetScore() // 15º --> metodo para que podamos acceder desde fuera y poner la puntuacion a cero
    {
        currentScore = 0; // 16º  --> Ponemos la puntuacion a cero
        scoreText.SetScore(currentScore); //17º --> Y por pantalla hacemos que salga 0 puntuaciones.
    }
}
