using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPooling : MonoBehaviour {
    public GameObject Terrain;
    public GameObject reference;
    //public GameObject GateWay;
    //public GameObject flasher;
    public List<GameObject> Terrainpool;
    public int countTerrain=4;
    bool firstime = true;
    public static TerrainPooling TPooling;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < countTerrain; i++)
        {
            GameObject temp = (GameObject)Instantiate(Terrain);
            temp.SetActive(false);
            Terrainpool.Add(temp);
        }
        TPooling = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (firstime)
        {
            TPooling.countTerrain = this.countTerrain;
            TPooling.Terrainpool = this.Terrainpool;
            TPooling.reference = this.reference;
            //TPooling.GateWay = this.GateWay;
        }
        
    }
    void DoItBitch()
    {
        Debug.Log("OH THE JOY MINUS 1 "+countTerrain);
        //Debug.Log(Terrainpool[0].activeInHierarchy);
        for (int i = 0; i < countTerrain; i++)
        {
            Debug.Log(Terrainpool[i].activeInHierarchy);
            if (!Terrainpool[i].activeInHierarchy)
            {
                Debug.Log("OH THE JOY");
                //Terrainpool[i].transform.position = reference.transform.position;
                Terrainpool[i].transform.position = new Vector3(reference.transform.position.x-138, 0.1F, reference.transform.position.z + 430);
                //Terrainpool [i].transform.rotation = reference.transform.rotation;
                //Terrainpool[i].transform.eulerAngles = reference.transform.eulerAngles;
                Terrainpool[i].SetActive(true);
                
               //
                break;
            }
        }
        //flasher.SetActive(true);
    }
    public void TriggerPooling()
    {
        Debug.Log("OH THE JOY MINUS 2 "+countTerrain);
        DoItBitch();
    }
    public void deactivationSequence(int limit)
    {
        for (int i = 0; i < limit; i++)
        {
            if(Terrainpool[i].activeInHierarchy)
            {
                Terrainpool[i].SetActive(false);
            }
        }
    }

}
