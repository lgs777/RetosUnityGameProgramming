﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

    public bool isOveraped = false;

    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;


    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }
    // 트리거인 콜라이더와 충돌할때 자동으로 실행
    // Enter 충돌을 한 그 순간
    void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
           
        }
       
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = false;
            myRenderer.material.color = originalColor;
          
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOveraped = true;
            myRenderer.material.color = touchColor;
           
        }

    }
}
