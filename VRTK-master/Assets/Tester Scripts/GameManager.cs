using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int score = 0;

    public GameObject highTester;
    public GameObject lowTester;

    private Tester_high ScriptHT;
    private Tester_low ScriptLT;

    public Text highscore;

    // Use this for initialization
    void Start () {
        ScriptHT = highTester.GetComponent<Tester_high>();
        ScriptLT = lowTester.GetComponent<Tester_low>();
    }
	
	// Update is called once per frame
	void Update () {
        scored();
        highscore.text = "Score: " + score;
	}

    public void scored ()
    {
        if(ScriptHT.passed && ScriptLT.passed)
        {
            score++;
            ScriptHT.passed = false;
            ScriptLT.passed = false;
        }
    }
}
