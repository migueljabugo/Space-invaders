using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour {

    public int scorePerHit = 10; // 1º -> variable de puntuacion por golpe
    public ScoreManager manager; // 6º --> referencia al script "ScoreManager"

    private void Start()
    {
        manager = GameObject.FindObjectOfType<ScoreManager>(); // 8º --> con este metodo, hacemos que ScoreObject encuentre al managers en escena automaticamente

    }
    private void OnCollisionEnter2D(Collision2D collision) //2º --> Metodo que detecte las colisiones
    {
        manager.AddScore(scorePerHit); // 7º -> añadimos las puntuaciones usando el metodo "AddScore" del ScoreManager
    }
}
