using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {
	public static bool state = false ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (state== true){
			Quaternion firstAngle = Quaternion.Euler (-89.98f, 0, -180);
			Quaternion lastAngle = firstAngle * Quaternion.Euler (90f , 0 , 0 );
			transform.rotation = Quaternion.Slerp (firstAngle, lastAngle, Time.time / 30f); 

		}
	}
	public void OnChestClicked(){
	
		if (Door.openingPhase ==true){

			state = true;
		}
			
		

	}
}
