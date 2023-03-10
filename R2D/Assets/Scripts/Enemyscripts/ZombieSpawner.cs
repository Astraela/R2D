using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

    public GameObject NoobPrefab;
    public GameObject GuestPrefab;
    float coolDown = 2;

    private GameObject ServerScript;
    private WaveScript wavescript;
    public int enemiesSpawned = 0;

    //public GameObject zombie = (GameObject)Instantiate(Resources.Load("NoobEnemy"));

    // Use this for initialization
    void Start () {
        ServerScript = GameObject.Find("Serverscripts");
        wavescript = ServerScript.GetComponent<WaveScript>();
    }

    int RandomNumber()
    {
        System.Random random = new System.Random();
        int result = random.Next();
        return result % 2;
    }

    // Update is called once per frame
    void Update() {

        coolDown -= Time.deltaTime;

        GameObject Noob;
        GameObject Guest;
        //float x = 27;
        //float y = -11;
        if (wavescript.isintermission == false) {
            if (coolDown <= 0 && enemiesSpawned < wavescript.Enemies) {

                coolDown = Random.Range(0.0f, 2.0f);

                System.Random random = new System.Random();
                int prefab = random.Next() % 3;
                //            int prefab = RandomNumber();
                if (prefab == 0)
                {
                    coolDown = 2;
                    Noob = Instantiate(NoobPrefab, transform.position, transform.rotation) as GameObject;

                    int pos = random.Next() % 2;
                    //                int pos = RandomNumber();
                    if (pos == 0)
                    {
                        Noob.transform.position = new Vector2(-27, -11);
                    }
                    else
                    {
                        Noob.transform.position = new Vector2(27, -11);
                    }

                }
                else
                {
                    coolDown = 2;
                    Guest = Instantiate(GuestPrefab, transform.position, transform.rotation) as GameObject;

                    int pos = random.Next() % 2;
                    //int pos = RandomNumber();
                    if (pos == 0)
                    {
                        Guest.transform.position = new Vector2(-27, -11);
                    }
                    else
                    {
                        Guest.transform.position = new Vector2(27, -11);
                    }

                }
                enemiesSpawned++;
            }
        }
    }
}
