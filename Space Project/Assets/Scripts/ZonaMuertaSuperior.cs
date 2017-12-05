using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para ir destruyendo las balas de la nave cuando salgan de pantalla por la parte superior

public class ZonaMuertaSuperior : MonoBehaviour {

   
    

    private void OnTriggerEnter2D(Collider2D BalaCollider)
  
    {
        GameObject bala = BalaCollider.gameObject;
        Rigidbody2D.Destroy(bala);
        
       
    }

    
}
