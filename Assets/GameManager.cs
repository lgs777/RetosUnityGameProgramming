using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	
	public ItemBox[] itemBoxs;
	public bool IsGameOver;
		
	// Use this for initialization
	void Start () {
		IsGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		//리턴은 함수가 리턴값을 돌려준다는 의미도 있지만 동시에 리턴이 나왔기 때문에 함수가 종료가 됨.
		if (IsGameOver == true)
		{
			return;
		}


		int count = 0;
		for (int i = 0; i < 3; i++) 
		{
			
			if (itemBoxs[i].isOverlaped == true) 
			{
				count++;
			}
		}

		if (count >= 3) 
		{
			Debug.Log ("게임승리");
			IsGameOver = true;
		}
	}
}
