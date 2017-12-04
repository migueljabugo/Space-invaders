using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour {

    public Transform spawnPositionBala;
    public GameObject marciano;

    


    private void OnCollisionEnter2D(Collision2D ballCollision)
    {
        

        Rigidbody2D.Destroy(marciano);

        


        GameObject bala = ballCollision.gameObject;
        Rigidbody2D.Destroy(bala);


        
    }


    
}
