using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTravelScript : MonoBehaviour {
	public float speed;
	[SerializeField]
	GameObject thisRef;
	//[SerializeField]
	//GameObject newRef;
	[SerializeField]
	GameObject BodyRef;
	[SerializeField]
	float range;
	[SerializeField]
	bool ranged, destructible;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//newRef.transform.Translate (0, speed, 0);
		thisRef.transform.Translate (0, speed, 0);
		if(Vector3.Distance (thisRef.transform.position, BodyRef.transform.position)>=range&&ranged){
			thisRef.SetActive (false);
		}
		Debug.Log ("Distance "+Vector3.Distance (thisRef.transform.position, BodyRef.transform.position));
	}
	void OnTriggerEnter (Collider other){
		if(destructible){
			thisRef.SetActive (false);
			Debug.Log ("rekt");
		}
	}

}
