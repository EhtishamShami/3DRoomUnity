using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour {
	public GameObject startposition;
	public GameObject Musictime;
	// Use this for initialization
	void Start () {
		transform.position = startposition.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("1") || Input.GetKey ("2") || Input.GetKey ("3") || Input.GetKey ("4") || Input.GetKey ("5") || Input.GetKey ("6") || Input.GetKey ("7") || Input.GetKey ("8") ) {

				transform.position=Musictime.transform.position;
			}
		else if(Input.GetKey("0")|| Input.GetKey ("9"))
			{
				transform.position=startposition.transform.position;
			}
		}	
	
}
