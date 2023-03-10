using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class EndlessScript : MonoBehaviour {
    public bool happening = true;
    private GameObject ServerScript;
    private WaveScript wavescript;
    private EnemyHealth enemyhealth;
    private ZombieSpawner zombiespawner;
    private EndlessScript endlessScript;
    public int bossWave = 1;
    public bool bossProgress = false;
    public int wave = 0;

    public GameObject boss30;
    public GameObject xLars;
    public GameObject Pascal255;
    public GameObject loleris;
    public GameObject TTP;
    public GameObject LightLimn;

    // Use this for initialization
    void Start () {
        ServerScript = GameObject.Find("Serverscripts");
        wavescript = ServerScript.GetComponent<WaveScript>();
        zombiespawner = ServerScript.GetComponent<ZombieSpawner>();
        endlessScript = ServerScript.GetComponent<EndlessScript>();
        wavescript.EnemieCount = 5;
        wavescript.Enemies = 5;

            
            string line = PlayerPrefs.GetString("mode");
            if (line == "StoryMode")
            {
                endlessScript.enabled = false;

            }
    }
	
	// Update is called once per frame
	void Update () {

        GameObject noob30;
        GameObject lars;
        GameObject pascal;
        GameObject lol;
        GameObject twenty;
        GameObject light;

        if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 3)
        {
            Debug.Log("Inside Wave");
            happening = false;
            wavescript.intermissionstart = true;
            bossWave++;
            wave++;
            if (wavescript.isintermission == false && bossWave < 3 && bossProgress == false)
            {
                Debug.Log("Beginning new Wave");
                wavescript.WaveCount++;
                wavescript.Enemies = Mathf.Floor(wavescript.Enemies *= 1.3f);
                wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                wavescript.textchange();
                happening = true;
                zombiespawner.enemiesSpawned = 0;
                Debug.Log(bossWave);
                if (bossWave == 3)
                {
                    bossProgress = true;
                    Debug.Log("bossProgress: " + bossProgress);
                }


            }
        }

        else
        {
            if (bossWave == 3)
            {
                Debug.Log("bossWave == 3");
                //wavescript.intermissionstart = true;
                if (wavescript.intermissionstart == false)
                {
                    
                    System.Random random = new System.Random();
                    int bossNumber = random.Next(1, 6);
                    Debug.Log("Spawning Boss: " + bossNumber);
                    if (bossNumber == 1)
                    {
                        bossWave = 0;
                        noob30 = Instantiate(boss30, transform.position, transform.rotation) as GameObject;
                        noob30.transform.position = new Vector2(-25, -3);
                    }

                    else if (bossNumber == 2)
                    {
                        bossWave = 0;
                        lars = Instantiate(xLars, transform.position, transform.rotation) as GameObject;
                        lars.transform.position = new Vector2(-25, -3);
                    }

                    else if (bossNumber == 3)
                    {
                        bossWave = 0;
                        pascal = Instantiate(Pascal255, transform.position, transform.rotation) as GameObject;
                        pascal.transform.position = new Vector2(-25, -3);
                    }

                    else if (bossNumber == 4)
                    {
                        bossWave = 0;
                        lol = Instantiate(loleris, transform.position, transform.rotation) as GameObject;
                        lol.transform.position = new Vector2(-25, -3);
                    }

                    else if (bossNumber == 5)
                    {
                        bossWave = 0;
                        twenty = Instantiate(TTP, transform.position, transform.rotation) as GameObject;
                        twenty.transform.position = new Vector2(-25, -3);
                    }

                    else if (bossNumber == 6)
                    {
                        bossWave = 0;
                        light = Instantiate(LightLimn, transform.position, transform.rotation) as GameObject;
                        light.transform.position = new Vector2(-25, -3);
                    }

                }
            }
        }
	}
}
