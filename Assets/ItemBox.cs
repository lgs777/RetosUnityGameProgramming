using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {

	public bool isOverlaped = false;

	private Renderer myRenderer;

	public Color touchColor;

	private Color originalColor;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer> ();
		originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "EndPoint")
		{
			myRenderer.material.color = touchColor;
			isOverlaped = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "EndPoint")
		{
			myRenderer.material.color = originalColor;
			isOverlaped = false;
		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag == "EndPoint")
		{
			myRenderer.material.color = touchColor;
			isOverlaped = true;
		}
	}
}
