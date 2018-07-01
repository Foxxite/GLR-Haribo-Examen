using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallu2 : MonoBehaviour {

    public GameObject HalluBol;
    public GameObject Candy1;
    public GameObject Candy2;
    public GameObject Candy3;
    public GameObject Level;
    public GameObject Walls;

	// Use this for initialization
	public void StartHallu () {
        StartCoroutine(StopHallu());
	}
	
	IEnumerator StopHallu()
    {
        Candy1.SetActive(false);
        Candy1.SetActive(false);
        Candy1.SetActive(false);
        Level.SetActive(false);
        Walls.SetActive(false);
        HalluBol.SetActive(true);
        yield return new WaitForSeconds(30);
        Candy1.SetActive(true);
        Candy1.SetActive(true);
        Candy1.SetActive(true);
        Level.SetActive(true);
        Walls.SetActive(true);
        HalluBol.SetActive(false);
    }
}
