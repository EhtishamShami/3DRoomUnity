using UnityEngine;
using System.Collections;

public class MultipleAudios : MonoBehaviour {
	AudioSource correctAudio;
	AudioSource errorAudio;
	
	void Start() {
		AudioSource[] audios = GetComponents<AudioSource>();
		errorAudio = audios[0];
		correctAudio = audios[1];
	}
	


	
	// Update is called once per frame
	void Update () {
	
	}
}
