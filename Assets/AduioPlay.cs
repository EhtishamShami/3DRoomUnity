using UnityEngine;
using System.Collections;

public class AduioPlay : MonoBehaviour {
	public AudioSource Audio1;
	public AudioSource Audio2;
	public AudioSource Audio3;
	public AudioSource Audio4;
	public AudioSource Audio5;
	public AudioSource Audio6;
	public AudioSource Audio7;
	// Use this for initialization

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		AudioSource audio = GetComponent<AudioSource> ();
		if (Input.GetKey ("1")) {		

			Audio1.Stop ();
			Audio2.Stop ();
			Audio3.Stop();
			Audio4.Stop ();
			Audio5.Stop ();
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Play ();
	
		} else if (Input.GetKey ("2")) {
		
			Audio2.Stop ();
			Audio3.Stop();
			Audio4.Stop ();
			Audio5.Stop ();
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Stop ();
			Audio1.Play ();

		} else if (Input.GetKey ("3")) {
			Audio3.Stop();
			Audio4.Stop ();
			Audio5.Stop ();
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Stop ();
			Audio1.Stop ();
			Audio2.Play ();
		}
		else if (Input.GetKey ("4")) {
			Audio4.Stop ();
			Audio5.Stop ();
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Play ();
		

		}
		else if (Input.GetKey ("5")) {

			Audio5.Stop ();
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Stop();
			Audio4.Play();
		}
		else if (Input.GetKey ("6")) {
			Audio6.Stop ();
			Audio7.Stop ();
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Stop();
			Audio4.Stop();
			Audio5.Play ();
		}
		else if (Input.GetKey ("7")) {
			Audio7.Stop ();
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Stop();
			Audio4.Stop();
			Audio5.Stop();
			Audio6.Play ();
		}
		else if (Input.GetKey ("8")) {
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Stop();
			Audio4.Stop();
			Audio5.Stop();
			Audio6.Stop();
			Audio7.Play();
		}
		else if(Input.GetKey("0"))
		{
			audio.Stop ();
			Audio2.Stop ();
			Audio1.Stop ();
			Audio3.Stop();
			Audio4.Stop();
			Audio5.Stop();
			Audio6.Stop();
			Audio7.Stop();		}
	}
}
