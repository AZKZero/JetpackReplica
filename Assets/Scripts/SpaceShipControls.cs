using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControls : MonoBehaviour
{
	[SerializeField]
	Rigidbody Body;
	[SerializeField]
	float sensitivityJump;
	[SerializeField]
	Light FrontLight;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("space")/*GetKeyDown in normal case*/)
		{
			Debug.Log("YAY");
			if (Input.GetKey("w"))
			{
				Body.AddForce((Body.transform.forward + Body.transform.up) * sensitivityJump);
			}
			else
				Body.AddForce(0, sensitivityJump, 0);
		}
		else if (Input.GetKey(KeyCode.LeftControl)/*GetKeyDown in normal case*/)
		{
			Debug.Log("YAY");
			if (Input.GetKey("w"))
			{
				Body.AddForce((Body.transform.forward - Body.transform.up) * sensitivityJump);
			}
			else
				Body.AddForce(0, -sensitivityJump, 0);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			 //enabled=false;
			FrontLight.enabled=!FrontLight.enabled;
		}
	}
}
