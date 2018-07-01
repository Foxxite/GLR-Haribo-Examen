using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyControl : MonoBehaviour {

    private Vector3 startPos;
    private Quaternion startRot;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
        startRot = transform.rotation;
	}
	
	// Update is called once per frame
	public void Reset () {
        transform.position = startPos;
        transform.rotation = startRot;
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
	}
}
