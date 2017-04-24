using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester_low : MonoBehaviour {

    public bool passed = false;

    public GameObject highTester;

    private Tester_high CheckIfPassed;

    // Use this for initialization
    void Start()
    {
        CheckIfPassed = highTester.GetComponent<Tester_high>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && CheckIfPassed.passed)
        {
            passed = true;
        }
    }
}
