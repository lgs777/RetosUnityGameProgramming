using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float sizeOfCircle = 30f;

        float radius = GetRadius(sizeOfCircle);

        Debug.Log("원의 사이즈는" + sizeOfCircle + "원의 반지름" + radius);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    float GetRadius (float size)
    {
        float pi = 3.14f;

        float tmp = size / pi;

        float radius = Mathf.Sqrt(tmp);

        return radius;
    }


}
