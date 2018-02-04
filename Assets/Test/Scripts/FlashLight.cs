using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

	public Light flashlight;
	public AudioSource audioSource;
	public AudioClip flashlight_on;
	public AudioClip flashlight_off;

	private bool isActive;

	// Use this for initialization
	void Start () {
		isActive = true;	
		//flashlight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			if (isActive == false) {
				flashlight.enabled = true;	
				isActive = true;

				audioSource.PlayOneShot (flashlight_on);
			} else {
				flashlight.enabled = false;
				isActive = false;

				audioSource.PlayOneShot (flashlight_off);			}
		}
	}
}
