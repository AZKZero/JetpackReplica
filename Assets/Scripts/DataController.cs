using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {
    public GameObject gameO;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameO);
	}
	// Update is called once per frame
	void Update () {
		
	}
    
}
