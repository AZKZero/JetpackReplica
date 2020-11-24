using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMotionScript : MonoBehaviour {
    public static ConstantMotionScript CMS;
    public float sensitivitySpeed;
    public bool isActivated=true;
	// Use this for initialization
	void Start () {
        CMS = this;
	}
	
	// Update is called once per frame
	void Update () {
        if(isActivated)
        transform.Translate(0, 0, sensitivitySpeed, Space.World);
        if (Input.GetKey("e")) sensitivitySpeed += 0.04f;
        if (Input.GetKey("q")) sensitivitySpeed -= 0.04f;
        if (sensitivitySpeed < 0) sensitivitySpeed = 0;
    }
}
