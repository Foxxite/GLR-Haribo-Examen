using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EatCandy : MonoBehaviour {

    public UnityEvent Hallu1;
    public UnityEvent Hallu2;
    public UnityEvent Hallu3;

    void Start()
    {
        Debug.Log(GetComponent<BoxCollider>().size);
        Debug.Log(GetComponent<BoxCollider>().isTrigger);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided Object: " + other.tag + " | " + other.name);
        if(other.tag == "Candy")
        {
            int r = Random.Range(0, 2);
            Debug.Log(r);
            if(r == 0)
            {
                Hallu1.Invoke();
                other.GetComponent<CanyControl>().Reset(); 
            }
            else if (r == 1)
            {
                Hallu2.Invoke();
                other.GetComponent<CanyControl>().Reset();
            }
            else
            {
                Hallu3.Invoke();
                other.GetComponent<CanyControl>().Reset();
            }
        }
    }
}
