using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHighscore : MonoBehaviour {

    public GameObject highscore;

	// Use this for initialization
	void Start () {
        highscore = GameObject.Find("Highscore");
	}
	
	// Update is called once per frame
	void Update () {
        highscore.GetComponent<Text>().text = "Highscore: " + PlayerPrefs.GetInt("HighestWave");
	}
}
