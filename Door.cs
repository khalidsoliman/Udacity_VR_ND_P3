using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour 
{

	// Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public static bool lockedPhase = false ;
	// Create a boolean value called "opening" that can be checked in Update() 
	public static bool openingPhase = false ;
		public AudioSource doorSoundSource;
	    public AudioClip doorOpeningSound;
	public AudioClip doorClosingSound;


	void Update() {
		//		
		if (openingPhase == true ) {

			if (transform.position.y < 8) {
				transform.Translate (0, 1.5f*Time.deltaTime, 0, Space.World);
			}

		}

		// If the door is opening and it is not fully raised
		// Animate the door raising up
	}

	public void OnDoorClicked() {
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		if ( Key.holdKey == true ) 
		{
			lockedPhase = false;
			openingPhase = true;
			doorSoundSource.clip = doorOpeningSound;
			doorSoundSource.Play (); 

		}
		else 
		{
			lockedPhase = true ;
			openingPhase = false ; 
			doorSoundSource.clip = doorClosingSound;
			doorSoundSource.Play ();
		}
		// (optionally) Else
		// Play a sound to indicate the door is locked
	}

	public void Unlock()
	{
		lockedPhase = false;
		// You'll need to set "locked" to false here

	}
}
