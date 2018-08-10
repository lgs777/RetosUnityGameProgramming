using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calcurator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(Sum(1, 1));
        Debug.Log(Sum(1, 2, 3));
        Debug.Log(Sum(1.0f, 3.2f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 오버로드 : 함수 이름은 같지만 입력의 갯수, 혹은 변수의 종류에 따라 다르게 작동한다
   
    public int Sum (int a, int b)
    {
        return a + b;
    }

    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public float Sum (float a, float b)
    {
        return a + b;
    }


}
