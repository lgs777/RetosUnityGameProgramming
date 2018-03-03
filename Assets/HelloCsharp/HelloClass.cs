using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Animal jack = new Animal();
        jack.name = "JACK";
        jack.sound = "BARK";
        jack.weight = 4.5f;

        Animal nate = new Animal();
        nate.name = "NATE";
        nate.sound = "Nyaaa";
        nate.weight = 1.2f;

        Animal Annie = new Animal();
        Annie.name = "ANNIE";
        Annie.sound = "Weeeee";
        Annie.weight = 0.5f;


		
	}
	
	

    public class Animal
    {
        public string name;
        public string sound;
        public float weight;
    }
}
