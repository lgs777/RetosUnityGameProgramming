using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour {

	// Use this for initialization
	void Start () {


        // 여러개의 값을 하나의 변수로 다루게 해준다.
        int[] scores = new int[10];



        scores[0] = 90;
        scores[1] = 45;
        scores[2] = 93;
        scores[3] = 43;
        scores[4] = 50;
        scores[5] = 60;
        scores[6] = 54;
        scores[7] = 98;
        scores[8] = 100;
        scores[9] = 33;

        for (int i = 0; i < 10; i++ )
        {
            Debug.Log("학생" + i + "번째의 점수" + scores[i]);
        }

	}
	
	


}
