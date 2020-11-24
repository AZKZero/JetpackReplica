using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherActions : MonoBehaviour
{
    public Rigidbody Body;
    public float sensitivityJump;
    private int i = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0, 0);
        if(Input.GetKeyDown("space"))
        {
            ConstantMotionScript.CMS.isActivated = !ConstantMotionScript.CMS.isActivated;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            ConstantMotionScript.CMS.sensitivitySpeed += 0.02F;
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            ConstantMotionScript.CMS.sensitivitySpeed -= 0.02F;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("GODDAMNIT " + TerrainPooling.TPooling.countTerrain);
        TerrainPooling.TPooling.TriggerPooling();
        
        i++;
        if (i == 3)
        {
            TerrainPooling.TPooling.deactivationSequence(1);
            i = 0;
        }
            
    }
}
