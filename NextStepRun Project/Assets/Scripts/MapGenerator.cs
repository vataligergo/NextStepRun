using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public GameObject[] MapParts;

    private Transform playerTransform;
    private float CreatePositionZ = 0.0f;
    private float PartLength = 15.0f;
    private int NumberOfPartsOnScreen = 10;



    // Use this for initialization
    private void Start ()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    
        for(int i = 0; i > NumberOfPartsOnScreen; i++)
        {
            MapGen();
        }
    }
	
	// Update is called once per frame
	private void Update ()
    {
        if (playerTransform.position.z > (CreatePositionZ - NumberOfPartsOnScreen * PartLength))
        {
            MapGen();
        }
    }

    private void MapGen() // a MapParts tömbből egymás mögé pakolja a pályadarabokat (int i = -1)
    {
        GameObject go;
        go = Instantiate(MapParts[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * CreatePositionZ;
        CreatePositionZ += PartLength;
    }
}
