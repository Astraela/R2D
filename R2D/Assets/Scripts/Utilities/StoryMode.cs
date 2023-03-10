using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class StoryMode : MonoBehaviour {

    public int level;
    private GameObject ServerScript;
    private WaveScript wavescript;
    private StoryMode storyMode;
    public bool happening = true;
    private ZombieSpawner zombiespawner;
    public bool bossProgress;
    public int bossWave;

    public GameObject Boss;

    // Use this for initialization
    void Start () {
        ServerScript = GameObject.Find("Serverscripts");
        wavescript = ServerScript.GetComponent<WaveScript>();
        zombiespawner = ServerScript.GetComponent<ZombieSpawner>();
        storyMode = ServerScript.GetComponent<StoryMode>();

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            
           
            string line = PlayerPrefs.GetString("mode");
            if (line == "FreeMode")
            {
                storyMode.enabled = false;
        }

        
                

        switch (level)
        {
            case 1:
                wavescript.Enemies = 1;
                wavescript.EnemieCount = 1;
                break;

            case 2:
                wavescript.Enemies = 2;
                wavescript.EnemieCount = 2;
                break;

            case 3:
                wavescript.Enemies = 3;
                wavescript.EnemieCount = 3;
                break;

            case 4:
                wavescript.Enemies = 4;
                wavescript.EnemieCount = 4;
                break;

            case 5:
                wavescript.Enemies = 5;
                wavescript.EnemieCount = 5;
                break;

            case 6:
                wavescript.Enemies = 1;
                wavescript.EnemieCount = 1;
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
        switch (level)
        {
            case 1:
                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 5)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 5 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        wavescript.Enemies = wavescript.Enemies + 2;
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 5)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 5)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;
                            
                        }
                    }
                }
                            break;

            case 2:

                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 5)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 5 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        wavescript.Enemies = wavescript.Enemies + 3;
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 5)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 5)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;

                        }
                    }
                }

                break;

            case 3:

                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 5)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 5 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        wavescript.Enemies = wavescript.Enemies + 4;
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 5)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 5)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;

                        }
                    }
                }
                break;

            case 4:

                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 5)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 5 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        wavescript.Enemies = wavescript.Enemies + 5;
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 5)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 5)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;

                        }
                    }
                }
                break;

            case 5:

                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 5)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 5 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        wavescript.Enemies = wavescript.Enemies + 6;
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 5)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 5)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;

                        }
                    }
                }
                break;

            case 6:

                if (wavescript.EnemieCount <= 0 && happening == true && bossProgress == false && bossWave < 10)
                {
                    Debug.Log("Inside Wave");
                    happening = false;
                    wavescript.intermissionstart = true;
                    bossWave++;
                    if (wavescript.isintermission == false && bossWave < 10 && bossProgress == false)
                    {
                        Debug.Log("Beginning new Wave");
                        wavescript.WaveCount++;
                        if (wavescript.WaveCount < 3)
                        {
                            wavescript.Enemies = wavescript.Enemies + 7;
                        }
                        else if (wavescript.WaveCount < 6)
                        {
                            wavescript.Enemies = wavescript.Enemies + 5;
                        }
                        else if (wavescript.WaveCount < 9)
                        {
                            wavescript.Enemies = wavescript.Enemies + 3;
                        }
                        else
                        {
                            wavescript.Enemies = wavescript.Enemies + 1;
                        }
                        wavescript.EnemieCount = Mathf.FloorToInt(wavescript.Enemies);
                        wavescript.textchange();
                        happening = true;
                        zombiespawner.enemiesSpawned = 0;
                        Debug.Log(bossWave);
                        if (bossWave == 10)
                        {
                            bossProgress = true;
                        }


                    }
                }
                else
                {
                    Debug.Log("In else");
                    if (bossWave == 10)
                    {
                        Debug.Log("bossWave == 3");
                        //wavescript.intermissionstart = true;
                        if (wavescript.intermissionstart == false)
                        {
                            bossProgress = true;
                            GameObject boss;
                            boss = Instantiate(Boss, transform.position, transform.rotation) as GameObject;
                            boss.transform.position = new Vector2(-27, -11);
                            bossWave = 0;

                        }
                    }
                }
                break;
        }
    }
    
}
