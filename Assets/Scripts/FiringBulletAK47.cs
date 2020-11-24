using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringBulletAK47 : MonoBehaviour {
	public GameObject bullet;
	public GameObject reference;
	public GameObject flasher;
	public List<GameObject> bulletpool;
	public int countBullet;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < countBullet; i++) {
			GameObject temp = (GameObject)Instantiate (bullet);
			temp.SetActive (false);
			bulletpool.Add (temp);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (flasher.activeInHierarchy)
			flasher.SetActive (false);
		if (Input.GetMouseButtonDown (0)/*Input.GetKeyDown ("l")*/) {
			Fire ();
		}
		/*else if(Input.GetMouseButton (0)){
			InvokeRepeating ("Fire", 0, Time.deltaTime);
		}
		else if(Input.GetMouseButtonUp (0)){
			CancelInvoke ("Fire");
		}*/
	}
	void Fire()
	{
		for (int i = 0; i < countBullet; i++) {
			if (!bulletpool [i].activeInHierarchy) {
				bulletpool [i].transform.position = reference.transform.position;
				//bulletpool [i].transform.rotation = reference.transform.rotation;
				bulletpool [i].transform.eulerAngles = reference.transform.eulerAngles;
				bulletpool [i].SetActive (true);
				break;
			}
		}
		flasher.SetActive (true);
	}
}
