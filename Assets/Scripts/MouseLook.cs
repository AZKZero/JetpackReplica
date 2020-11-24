using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public GameObject gObj;
    public float sensitivityMouse;
	// Use this for initialization
	void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {
        float UpDown = Input.GetAxis("Mouse Y");
        float LeftRight = Input.GetAxis("Mouse X");
        // gObj.transform.rotation.z.
        gObj.transform.Rotate(new Vector3(-UpDown * sensitivityMouse, LeftRight * sensitivityMouse, 0), Space.Self);
        //gObj.transform.Rotate(Vector3.right, UpDown*sensitivityMouse);
       // gObj.transform.rotation.SetAxisAngle(Vector3.forward, 0);
        //gObj.transform.Rotate(Vector3.up, LeftRight*sensitivityMouse);
	}
}
