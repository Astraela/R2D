using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveScript : MonoBehaviour {

    public Text EnemiesLeft;
    public Text Wave;
	public Text intermissionTXT;
    public int EnemieCount = 5;
    public int WaveCount = 1;
    public float countDown = 5;
    public float Enemies = 5;
    public bool isintermission = true;
    public bool intermissionstart = false;
	// Use this for initialization
	void Start () {
		intermissionTXT.enabled = false;
        EnemiesLeft.text = ("Enemies left:" + EnemieCount);
        Wave.text = ("Wave: " + WaveCount);
	}
	
	// Update is called once per frame
	private void Update () {
        if (intermissionstart == true)
        {
			intermissionTXT.enabled = true;
			isintermission = true;
                countDown -= Time.deltaTime;
                if (countDown <= 0)
                {
					intermissionTXT.enabled = false;
                    countDown = 5;
                    //Debug.Log("Waited 5 sec");
                    isintermission = false;
                    intermissionstart = false;
                }
                //Debug.Log(countDown);
        }

	}
    public void textchange()
    {
        EnemiesLeft.text = ("Enemies left: " + EnemieCount + "  ");
        Wave.text = ("Wave: " + WaveCount + "  ");
    }
    public void intermission()
    {
        

    }
}
