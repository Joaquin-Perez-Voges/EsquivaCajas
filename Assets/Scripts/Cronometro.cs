using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Cronometro : MonoBehaviour
{
    public TMP_Text UICronometro; 
    bool timer = true;
    float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer){
        tiempo += Time.deltaTime;
        UICronometro.text = "Tiempo: " + tiempo.ToString("F2");
        }
          

    }
    public void PausarTimer()
    {
        timer=false;
    }
}

