using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

	public GameObject roadPrefab;
	public float offset = 0.71f;
	public Vector3 lastPoss;

	private int roadCount = 0;

	public void StartBuilding(){
		InvokeRepeating ("CreateNewRoadPart", 1f, .2f);
	}

	public void CreateNewRoadPart(){
		Debug.Log ("Create new road part");

		Vector3 spawnPoss = Vector3.zero;

		float chance = Random.Range (0, 100);

		if (chance < 50) {
			spawnPoss = new Vector3 (lastPoss.x + offset, lastPoss.y, lastPoss.z + offset);
		} else {
			spawnPoss = new Vector3 (lastPoss.x - offset, lastPoss.y, lastPoss.z + offset);
		}

		GameObject g = Instantiate (roadPrefab, spawnPoss, Quaternion.Euler(0, 45, 0));

		lastPoss = g.transform.position;

		roadCount++;

		if(roadCount % 5 ==0){
			g.transform.GetChild (0).gameObject.SetActive(true);
		}
	}


	/*
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			CreateNewRoadPart ();
		}
	}
	*/
}
