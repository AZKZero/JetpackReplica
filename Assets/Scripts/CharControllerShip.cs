using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControllerShip : MonoBehaviour
{
    [SerializeField]
    GameObject SpaceShipObj, Torso;
    [SerializeField]
    Rigidbody SpaceShip;
    [SerializeField]
    TrailRenderer ShipTrail;
    [SerializeField]
    float sensitivity;
    //float 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            
            if (Input.GetKey("w"))
            {
                SpaceShip.AddForce(SpaceShip.transform.forward);
                //SpaceShipObj.transform.Translate(0, -sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity*Vector3.ProjectOnPlane(SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                //Debug.Log("yeaa");
            }
            else if (Input.GetKey("s"))
            {
                SpaceShip.AddForce(-SpaceShip.transform.forward);
                //SpaceShipObj.transform.Translate(0, sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                //Debug.Log("yeaa");
            }
            else if (Input.GetKey("a"))
            {
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
				SpaceShip.transform.rotation=Quaternion.Lerp(SpaceShip.transform.rotation, Quaternion.Euler(0, 0, 70), Time.deltaTime);
                //SpaceShipObj.transform.Translate(0, 0, -sensitivity);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                //Debug.Log("yeaa");
            }
            else if (Input.GetKey("d"))
            {
                //SpaceShip.AddForce(sensitivity * Vector3.ProjectOnPlane(SpaceShipObj.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                ///SpaceShip.AddForce(sensitivity, 0, 0);
				float xRot = SpaceShip.transform.rotation.x;
				float yRot = SpaceShip.transform.rotation.y;
				SpaceShip.transform.rotation=Quaternion.Lerp(SpaceShip.transform.rotation, Quaternion.Euler(SpaceShip.transform.rotation.x, SpaceShip.transform.rotation.y, -70), Time.deltaTime);
				SpaceShip.transform.localEulerAngles = new Vector3 (xRot, yRot, SpaceShip.transform.rotation.z);
                //SpaceShipObj.transform.Translate(0, 0, sensitivity);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                Debug.Log("yeaa");
            }
            else if (Input.GetKey("s") && Input.GetKey("a"))
            {
                SpaceShip.AddForce(-sensitivity, 0, -sensitivity);
                //SpaceShipObj.transform.Translate(0, sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                Debug.Log("yeaa");
            }
            else if (Input.GetKey("s") && Input.GetKey("d"))
            {
                SpaceShipObj.transform.Translate(sensitivity, 0, -sensitivity);
                //SpaceShipObj.transform.Translate(0, sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                Debug.Log("yeaa");
            }
            else if (Input.GetKey("w") && Input.GetKey("a"))
            {
                SpaceShipObj.transform.Translate(-sensitivity, 0, sensitivity);
                //SpaceShipObj.transform.Translate(0, sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                Debug.Log("yeaa");
            }
            else if (Input.GetKey("w") && Input.GetKey("d"))
            {
                SpaceShipObj.transform.Translate(sensitivity, 0, sensitivity);
                //SpaceShipObj.transform.Translate(0, sensitivity, 0);
                //SpaceShipObj.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-SpaceShipObj.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
                //.position.Set(SpaceShipObj.transform.position.x, SpaceShipObj.transform.position.y, SpaceShipObj.transform.position.z+2);
                Debug.Log("yeaa");
            }
        }
        //else ShipTrail.enabled = false;
    }
    protected void LateUpdate()
    {
        //Torso.transform.localEulerAngles = new Vector3(Torso.transform.localEulerAngles.x, Torso.transform.localEulerAngles.y, 0);
        //OnlyRigid.transform.localEulerAngles = new Vector3(0,OnlyRigid.transform.localEulerAngles.y, 0);
        //RightRigid.transform.localEulerAngles = new Vector3(RightRigid.transform.localEulerAngles.x, 0, 0);
    }
}
