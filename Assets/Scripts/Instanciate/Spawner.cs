using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject target;

    public Transform spawnPositon;

    

	// Use this for initialization
	void Start () {

        //Target 에 지정된 오브젝트를 Instantiate 함수를 이용해 SpawnPosition 위치에 생성한다. 복제한 오브젝트를 
        //다시 Gameobject 변수에 넣어서 활용할 수 있다.
        //만약 위의 Target 변수가 Gameobject가 아니고 rigidbody 변수라면  Getcomponent를 통해  rigidbody에 접근할 필요없이
        // target.addforce (x, y, z); 로 바로 접근이 가능하다.

        target = Instantiate(target, spawnPositon.position, spawnPositon.rotation);
        target.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1000, 0));


    }

    // Update is called once per frame
    void Update () {

        
	}
}
