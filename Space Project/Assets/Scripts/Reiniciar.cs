using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour {

    public TextMesh gameOver;
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
                SceneManager.LoadScene("SpaceInvaders");
                Time.timeScale = 1;
            gameOver.text = "";
        }
	}
}
