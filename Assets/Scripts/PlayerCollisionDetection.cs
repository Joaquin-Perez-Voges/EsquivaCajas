using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    public Cronometro UICronometro;
    void Start()
    {
        UICronometro = FindObjectOfType<Cronometro>();
    }

    void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
            UICronometro.PausarTimer();

        }
    }
    

}
