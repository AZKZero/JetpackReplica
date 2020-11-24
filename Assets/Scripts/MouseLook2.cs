using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook2 : MonoBehaviour
{

    public GameObject gObj1;
    public GameObject gObj2;
    public float sensitivityMouseLeft;
    public float sensitivityMouseUp;
	bool inverse=false;
    void Update()
    {
        float LeftRight = Input.GetAxis("Mouse X");
        float UpDown = Input.GetAxis("Mouse Y");
		if (-UpDown < 0) {
			inverse = false;
		} else {
			inverse = true;
		}
        Debug.Log("LeftRight: "+LeftRight+" Angle: " + Vector3.Angle(gObj1.transform.up, gObj2.transform.forward));
        gObj2.transform.Rotate(0, LeftRight * sensitivityMouseLeft, 0);
        if (Vector3.Angle(gObj1.transform.up, gObj2.transform.forward) >= 110)
        {
            gObj1.transform.Rotate(new Vector3(0, 0, -UpDown * sensitivityMouseUp), Space.Self);
			Debug.Log(-UpDown + "Y Rotated "+Vector3.Angle(gObj1.transform.up, gObj2.transform.forward));
			Debug.Log (gObj1.transform.localEulerAngles);
        }
        else if (Vector3.Angle(gObj1.transform.up, gObj2.transform.forward) < 110)
        {
			if(gObj1.transform.localEulerAngles.z>0&&gObj1.transform.localEulerAngles.z<90)
				gObj1.transform.localEulerAngles = new Vector3 (0, 0, 60);
			else if(gObj1.transform.localEulerAngles.z>100&&gObj1.transform.localEulerAngles.z<360)
				gObj1.transform.localEulerAngles = new Vector3 (0, 0, 295);
        }
    }
    private void LateUpdate()
    {
        gObj1.transform.localEulerAngles = new Vector3(gObj1.transform.localEulerAngles.x, 0, gObj1.transform.localEulerAngles.z);
        gObj2.transform.localEulerAngles = new Vector3(0, gObj2.transform.localEulerAngles.y, 0);
    }
}
