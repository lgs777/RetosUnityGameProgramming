using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCsharp : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        //형변환 캐스팅
        int height = 170;
        float detailHeight = 170.3f;

        //자동형변환 (잃어버리는 정보가 없으면)
        detailHeight = height;

        //직접명시해야 하는 경우  (잃어버리는 정보가 있으면)
        height = (int)detailHeight;


        //조건문 if문
        bool isBoy = true;

        if (isBoy == true)
        {
            Debug.Log("나는 남자다");
        }


        int love = 50;

        if (love < 60)
        {
            Debug.Log("배드엔딩");
        }
        else
        {
            Debug.Log("해피엔딩");
        }


        int age = 60;


        // ||는 혹은, OR 의 역할을 함.
        // A || B   둘중 하나만 참이면 참.
        if (age < 60 || age < 17)
        {
            Debug.Log("일을 하면 안된다");
        }

        // AND && 그리고
        // A && B  A 그리고 B,  A와 B가 모두 참이어야 참.

        if (age > 17 && age < 60)
        {
            Debug.Log("일할 나이");
        }

        if (age < 7)
        {
            Debug.Log("유치원에 간다");
        }

        // age >= 12 그리고 age < 15
        else if (age < 12)
        {
            Debug.Log("초등학교에 간다");
        }
        else if (age < 15)
        {
            Debug.Log("중학교에 간다");
        }
        else if (age < 18)
        {
            Debug.Log("고등학교에 간다");
        }
        else
        {
            Debug.Log("성인");
        }

        //Switch 분기문

        int year = 2017;

        switch(year)
        {
            case 2012:
                Debug.Log("레미제라블");
                break;

            case 2015:
                Debug.Log("러브라이브");
                break;

            case 2016:
                Debug.Log("곡성");
                break;

            case 2017:
                Debug.Log("트랜스포머5");
                break;

            default:
                Debug.Log("년도가 해당사항없음");
                break;
        }

        // 루프문  Loop 반복문들

        // for 문
        // 초기화; 조건; 업데이트
        
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("현재 순번:" + i);
        }

        //While 문
        //

        bool isShot = false;
        int index = 0;
        int luckyNum = 4;

        while (isShot == false)
        {
            index = index + 1;
            Debug.Log("현재시도 : " + index);

            if (index == luckyNum)
            {
                Debug.Log("총알에 맞았다");
                isShot = true;
            }
            else
            {
                Debug.Log("총알에 맞지 않았다");
            }
          
        }
        

    }




      
    
}
