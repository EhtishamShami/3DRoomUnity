using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	// Use this for initialization
	bool check;
	void Start () {
		check =true;
		//transform.Translate (new Vector3 (0,0,1));
	}

	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetKey("i"))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey("k"))
			transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
		
		if(Input.GetKey("j"))
			transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
		
		if(Input.GetKey("l"))
			transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
*/
		if (Input.GetKey ("y") && check == true) {
			transform.Translate (new Vector3 (0, 0, 100) * 2 * Time.deltaTime);
			check = false;
		} else if (Input.GetKey ("g") && check == false) {
			transform.Translate (new Vector3 (0, 0, -100) * 2 * Time.deltaTime);
			check = true;		
		}
	}
}
