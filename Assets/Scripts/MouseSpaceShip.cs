using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSpaceShip : MonoBehaviour
{

    public GameObject SpaceShip;
    public GameObject gObj2;
    public float LookSensitivity;

    // Update is called once per frame
    void Update()
    {
        float LeftRight = Input.GetAxis("Mouse X");
        float UpDown = Input.GetAxis("Mouse Y");
        Debug.Log("LeftRight: " + LeftRight + " Angle: " + Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward));
        // gObj.transform.rotation.z.
        //if(Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward)>=120|| Vector3.Angle(SpaceShip.transform.forward, SpaceShip.transform.up) >= 120)
        //{
        //    SpaceShip.transform.Rotate(new Vector3(LeftRight * sensitivityMouse2, 0, UpDown * sensitivityMouse2), Space.Self);
        //    Debug.Log("Rotated");
        //    //SpaceShip.transform.Rotate(new Vector3(0, -LeftRight * sensitivityMouse2, 0), Space.Self);
        //}
        //else if(Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward)<120)
        //{
        //    SpaceShip.transform.Rotate(new Vector3(UpDown * sensitivityMouse2, 0, LeftRight * sensitivityMouse2), Space.Self);
        //}
        //else if (Vector3.Angle(SpaceShip.transform.forward, SpaceShip.transform.up) < 120)
        //{
        //    SpaceShip.transform.Rotate(new Vector3(-UpDown * sensitivityMouse2, 0, LeftRight * sensitivityMouse2), Space.Self);
        //}
        SpaceShip.transform.Rotate(UpDown * LookSensitivity, LeftRight * LookSensitivity, 0);
        /*
        if (Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward) >= 120 || Vector3.Angle(SpaceShip.transform.forward, SpaceShip.transform.up) >= 120)
        {
            SpaceShip.transform.Rotate(new Vector3(0, 0, -UpDown * sensitivityMouseUp), Space.Self);
            Debug.Log("Rotated");
            //SpaceShip.transform.Rotate(new Vector3(0, -LeftRight * sensitivityMouse2, 0), Space.Self);
        }
        else if (Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward) < 120)
        {
            SpaceShip.transform.Rotate(new Vector3(0, 0, -UpDown * sensitivityMouseUp), Space.Self);
        }
        else if (Vector3.Angle(SpaceShip.transform.forward, SpaceShip.transform.up) < 120)
        {
            SpaceShip.transform.Rotate(new Vector3(0, 0, UpDown * sensitivityMouseUp), Space.Self);
        }
        */
        //if(Vector3.Angle(SpaceShip.transform.up, SpaceShip.transform.forward)>=120|| Vector3.Angle(SpaceShip.transform.forward, SpaceShip.transform.up) >= 120)
        //{
        //    SpaceShip.transform.Rotate(new Vector3(LeftRight * sensitivityMouse2, 0, UpDown * sensitivityMouse2), Space.Self);
        //    Debug.Log("Rotated");
        //    //SpaceShip.transform.Rotate(new Vector3(0, -LeftRight * sensitivityMouse2, 0), Space.Self);
        //}
        //gObj.transform.Rotate(Vector3.right, UpDown*sensitivityMouse);
        // gObj.transform.rotation.SetAxisAngle(Vector3.forward, 0);
        //gObj.transform.Rotate(Vector3.up, LeftRight*sensitivityMouse);
    }
    /**
     * private void LateUpdate()
    {
        SpaceShip.transform.localEulerAngles = new Vector3(SpaceShip.transform.localEulerAngles.x, 0, SpaceShip.transform.localEulerAngles.z);
        SpaceShip.transform.localEulerAngles = new Vector3(0, SpaceShip.transform.localEulerAngles.y, 0);
        Debug.Log("In LateUpdate: " + SpaceShip.transform.localEulerAngles.x + " " + SpaceShip.transform.localEulerAngles.z + " " + SpaceShip.transform.localEulerAngles.y);
    }**/
}
