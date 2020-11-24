using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{

    public GameObject Legs, Torso;
    public Rigidbody OnlyRigid;
    public float sensitivity;
    //float 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Legs.transform.Translate(0, sensitivity, 0, Space.World);
            //Legs.transform.Translate(0, -sensitivity, 0);
            //Legs.transform.Translate(sensitivity*Vector3.ProjectOnPlane(Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            //Debug.Log("yeaa");
        }
        else if (Input.GetKey("s"))
        {
            Legs.transform.Translate(0, -sensitivity, 0, Space.World);
            //Legs.transform.Translate(0, sensitivity, 0);
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            //Debug.Log("yeaa");
        }
        else if (Input.GetKey("a"))
        {
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            Legs.transform.Translate(-sensitivity, 0, 0, Space.World);
            //Legs.transform.Translate(0, 0, -sensitivity);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            //Debug.Log("yeaa");
        }
        else if (Input.GetKey("d"))
        {
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(Legs.transform.right, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            Legs.transform.Translate(sensitivity, 0, 0, Space.World);
            //Legs.transform.Translate(0, 0, sensitivity);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            //Debug.Log("yeaa");
        }
        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
            Legs.transform.Translate(-sensitivity, 0, -sensitivity, Space.Self);
            //Legs.transform.Translate(0, sensitivity, 0);
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
            Legs.transform.Translate(sensitivity, 0, -sensitivity, Space.Self);
            //Legs.transform.Translate(0, sensitivity, 0);
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("w") && Input.GetKey("a"))
        {
            Legs.transform.Translate(-sensitivity, 0, sensitivity, Space.Self);
            //Legs.transform.Translate(0, sensitivity, 0);
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            Debug.Log("yeaa");
        }
        else if (Input.GetKey("w") && Input.GetKey("d"))
        {
            Legs.transform.Translate(sensitivity, 0, sensitivity, Space.Self);
            //Legs.transform.Translate(0, sensitivity, 0);
            //Legs.transform.Translate(sensitivity * Vector3.ProjectOnPlane(-Legs.transform.forward, Vector3.Cross(Vector3.right, Vector3.forward)), Space.World);
            //.position.Set(Legs.transform.position.x, Legs.transform.position.y, Legs.transform.position.z+2);
            Debug.Log("yeaa");
        }
    }
    protected void LateUpdate()
    {
        //Torso.transform.localEulerAngles = new Vector3(Torso.transform.localEulerAngles.x, Torso.transform.localEulerAngles.y, 0);
        //OnlyRigid.transform.localEulerAngles = new Vector3(0,OnlyRigid.transform.localEulerAngles.y, 0);
        //RightRigid.transform.localEulerAngles = new Vector3(RightRigid.transform.localEulerAngles.x, 0, 0);
    }
}
