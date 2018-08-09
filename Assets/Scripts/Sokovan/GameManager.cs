using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public ItemBox[] itemBoxs;
    public bool isGameOver;
    public GameObject winUI;

	// Use this for initialization
	void Start () {

        isGameOver = false;

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }

        if(isGameOver == true)
        {
            return;
        }


        int count = 0;
        for(int i = 0; i < 3; i++)
        {   
            if (itemBoxs[i].isOveraped == true)
            {
                count++;
            }
            if (count >= 3)
            {
                Debug.Log("게임승리!");
                winUI.SetActive(true);
                isGameOver = true;
            }

        }

	}
}
