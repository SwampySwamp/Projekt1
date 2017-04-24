using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester_high : MonoBehaviour {

    public bool passed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            passed = true;
        }
    }
}
