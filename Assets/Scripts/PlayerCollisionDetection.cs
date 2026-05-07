using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
    }
}
