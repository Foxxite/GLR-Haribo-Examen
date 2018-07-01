using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallu1 : MonoBehaviour {

    public Camera vrCam;

	// Use this for initialization
	public void StartHallu()
    {
        StartCoroutine(keepFov());
    }

    IEnumerator keepFov()
    {
        vrCam.fieldOfView = 145;
        yield return new WaitForSeconds(30);
        vrCam.fieldOfView = 60;
    }
}
