using UnityEngine;
using System.Collections;

public class PooStain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("MOHAMMED");
		// derka derka
		Debug.Log("DERKA DERKA");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = this.transform.position + new Vector3(0f, 0.01f, 0f);
		//oops HACK
		this.transform.position = this.transform.position + new Vector3(0.001f, 0f, 0f);
		//derpderk
		this.transform.position = this.transform.position + new Vector3(0f, -0.01f, 0f);
	}

	private void test1() {

	}

	private void test2() {

	}

	private void test3() {

	}
}
