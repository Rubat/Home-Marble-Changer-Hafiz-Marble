using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changematerial : MonoBehaviour {

    public Material oldMat;
    public Material newMat;
    
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = oldMat;
        Invoke("m1", 1.0f);
	}

    void m1()
    {
        GetComponent<Renderer>().material = oldMat;
        Invoke("m2", 1.0f);

    }
    
    void m2()
    {
        GetComponent<Renderer>().material = newMat;
        Invoke("m1", 1.0f);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
