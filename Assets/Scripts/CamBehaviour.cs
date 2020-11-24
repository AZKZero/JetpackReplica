using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour {

    public GameObject egd, eff;
    public float sensitivity;
    //float 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey("w"))
        {
            egd.transform.Translate(sensitivity*Vector3.ProjectOnPlane(egd.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(egd.transform.position.x, egd.transform.position.y, egd.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("s"))
        {
            egd.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-egd.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(egd.transform.position.x, egd.transform.position.y, egd.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("a"))
        {
            egd.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-egd.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //egd.transform.Translate(-sensitivity, 0, 0);
            //.position.Set(egd.transform.position.x, egd.transform.position.y, egd.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("d"))
        {
            egd.transform.Translate(sensitivity * Vector3.ProjectOnPlane(egd.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //egd.transform.Translate(sensitivity, 0, 0);
            //.position.Set(egd.transform.position.x, egd.transform.position.y, egd.transform.position.z+2);
            Debug.Log("yeaa");
        }
    }
    protected void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);
    }
}
