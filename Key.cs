using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Key : MonoBehaviour 
{
	
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab ;
//	public GameObject doorPrefab ;
	public static bool holdKey  ;
	public AudioSource theSource ;
	public AudioClip theKeyClip;

	void Update()
	{
		if (holdKey == true){
			Quaternion firstAngle = Quaternion.Euler (-90f, 0, -80);
			Quaternion lastAngle = firstAngle * Quaternion.Euler (0 , 0 , 180);
			transform.rotation = Quaternion.Slerp (firstAngle, lastAngle, Time.time /30f); 

		}
	}

	public void OnKeyClicked()
	{
		holdKey = true;
        // Instatiate the KeyPoof Prefab where this key is located
		Object.Instantiate (keyPoofPrefab , transform.position , Quaternion.identity);
		theSource.clip = theKeyClip;
		theSource.Play ();

        // Make sure the poof animates vertically

        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy (gameObject , 3f);

    }

}
