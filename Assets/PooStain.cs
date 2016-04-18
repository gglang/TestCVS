using UnityEngine;
using System.Collections;

public class PooStain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// derka derka
		Debug.Log("DERKA DERKA");
	}
	
	// Update is called once per frame
	void Update () {
		//oops HACK
		this.transform.position = this.transform.position + new Vector3(0.001f, 0f, 0f);
		//derpderk
		this.transform.position = this.transform.position + new Vector3(0f, -0.01f, 0f);
	}
}
