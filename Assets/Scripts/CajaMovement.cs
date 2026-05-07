using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float velocidadCaja;
    float initialYValue;

    void Start()
    {
        initialYValue = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-velocidadCaja * Time.deltaTime ,0);
    }

    public void MoveBoxToRandomPosition()
    {       
        int randomXPosition = Random.Range(-2,3);
        Vector3 newPosition = transform.position;
        newPosition.y = initialYValue;
        newPosition.x = randomXPosition;
        transform.position = newPosition;
        
        
    }
}
