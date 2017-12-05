using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script para la destruccion de los marcianos cuando reciban la colision de las balas de la nave

public class ImpactoMarciano : MonoBehaviour {

    //public Transform spawnPositionBala;
    public GameObject marciano;
    

    


    private void OnCollisionEnter2D(Collision2D ballCollision)
    {


        Rigidbody2D.Destroy(marciano);

        


        GameObject bala = ballCollision.gameObject;
        Rigidbody2D.Destroy(bala);


        
    }


    
}
