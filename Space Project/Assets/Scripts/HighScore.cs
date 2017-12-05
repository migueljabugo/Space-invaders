using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para guardar la puntuacion maxima obtenida.

public class HighScore : MonoBehaviour {
    public int puntuacionMaxima; 
    
    
    public TextMesh highScore;


  
    
    

    public void GuardarPuntuacion(int puntuacionActual) //metodo para ir guardando la puntuacion maxima
    {
        puntuacionMaxima = PlayerPrefs.GetInt("PuntuacionMaxima", puntuacionMaxima); //al principio obtenemos la puntuacion maxima guardada
        //puntuacionMaxima = 0;
        if (puntuacionActual > puntuacionMaxima) 
        {
            puntuacionMaxima = puntuacionActual; //cuando la puntuacion obtenida sea mayor que la maxima que tengamos guardada, lo sobreescribimo
            highScore.text = puntuacionMaxima.ToString(); //lo sacamos por pantalla
            PlayerPrefs.SetInt("PuntuacionMaxima", puntuacionMaxima); // y lo guardamos.
            //Debug.Log("Datos Guardados: " + puntuacionMaxima);
        }

        
    }
    public void PuntuacionGuardada() //metodo para obtener la puntuacion guardada
    {
         int textoGuardado = PlayerPrefs.GetInt("PuntuacionMaxima", puntuacionMaxima);
         highScore.text = textoGuardado.ToString();
    }
}
