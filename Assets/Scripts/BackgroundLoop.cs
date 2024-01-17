using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour {

	public static BackgroundLoop instance;

	private void Awake(){
		if(instance == null){
			instance = this;
		}else if(instance!=this){
			//it will destroy object because it wont create just one bacground loop once with music not many times when game is restating
			Destroy (gameObject);
		}


		//gameObject means that it is what contains this script
		// so this music survive from one scene to another
		DontDestroyOnLoad (gameObject);


	}
}
