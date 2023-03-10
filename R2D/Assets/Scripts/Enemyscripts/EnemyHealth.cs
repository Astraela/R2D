using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
    public float health;
    public int credits;
    private WaveScript Wavescript;
    private GameObject serverscripts;
    public GameObject creditstxt;
	// Use this for initialization
	void Start () {
        serverscripts = GameObject.Find("Serverscripts");
        Wavescript = serverscripts.GetComponent<WaveScript>();
        creditstxt = GameObject.Find("CreditsTXT");
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Debug.Log ("OEH");

            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") + credits);
            creditstxt.GetComponent<Text>().text = "Credits: " + PlayerPrefs.GetInt("Credits");

            Wavescript.EnemieCount -= 1;
            Destroy(gameObject);
            Wavescript.textchange();
        }

	}
}
