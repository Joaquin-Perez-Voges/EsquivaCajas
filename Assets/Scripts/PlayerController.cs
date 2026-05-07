using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(2,0,0);
        }
        else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-2,0,0);
        }
        if(transform.position.x >= 2)
        {
          transform.position = new Vector3(2,transform.position.y,transform.position.z);
        }
        if(transform.position.x <= -2)
        {
          transform.position = new Vector3(-2,transform.position.y,transform.position.z);
        }
    }
}
