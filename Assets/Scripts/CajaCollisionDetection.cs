using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollisionDetection : MonoBehaviour
{
    public CajaMovement cajaMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        cajaMovementScript = GetComponent<CajaMovement>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Piso"))
        {
            cajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}
