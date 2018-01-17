using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform WhereToLook;
    private Vector3 StarterTransform;
    private Vector3 moveVector;

	// Use this for initialization
	void Start ()
    {
        WhereToLook = GameObject.FindGameObjectWithTag("Player").transform;
        StarterTransform = transform.position - WhereToLook.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        moveVector = WhereToLook.position + StarterTransform;
        //oldalirányú kameramozgás
        moveVector.x = 0;
        //függőleges kameramozgás
        moveVector.y = 3;
        transform.position = moveVector;
	}
}
