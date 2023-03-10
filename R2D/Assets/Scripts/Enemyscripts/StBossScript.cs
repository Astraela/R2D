using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StBossScript : MonoBehaviour {
    private GameObject serverscripts;
    private StoryMode storymode;
    private  WaveScript Wavescript;
    private EndlessScript Endlessscript;
    public GameObject creditstxt;
    public float health;
    public int credits;
    // Use this for initialization
    void Start () {

        serverscripts = GameObject.Find("Serverscripts");
        storymode = serverscripts.GetComponent<StoryMode>();
        Wavescript = serverscripts.GetComponent<WaveScript>();
        Endlessscript = serverscripts.GetComponent<EndlessScript>();
        creditstxt = GameObject.Find("CreditsTXT");
    }
	
	// Update is called once per frame
	void Update () {

        if (health <= 0 && storymode.enabled == true)
        {
            Wavescript.EnemieCount -= 1;
            switch (storymode.level)
            {
                case 1:
                    SceneManager.LoadScene("level2");
                    break;
                case 2:
                    SceneManager.LoadScene("level3");
                    break;
                case 3:
                    SceneManager.LoadScene("level4");
                    break;
                case 4:
                    SceneManager.LoadScene("level5");
                    break;
                case 5:
                    SceneManager.LoadScene("level6");
                    break;
                case 6:
                    SceneManager.LoadScene("winscreen");
                    break;
            }
        }
        else if (health <= 0)
        {
            Destroy(gameObject);

            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") + credits);
            creditstxt.GetComponent<Text>().text = "Credits: " + PlayerPrefs.GetInt("Credits");

            Wavescript.textchange();
            Endlessscript.happening = true;
            Endlessscript.bossProgress = false;
        }

    }

    void death()
    {

    }
}
