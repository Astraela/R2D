using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hatstore : MonoBehaviour {
    private GameObject txt;
    private GameObject text;
    void Start ()
    {
        txt = GameObject.Find("Credits");
        if (PlayerPrefs.HasKey("Credits"))
        {
            txt.GetComponent<Text>().text = "Credits: " + PlayerPrefs.GetInt("Credits");
        }
        else
        {
            PlayerPrefs.SetInt("Credits", 0);
            txt.GetComponent<Text>().text = "Credits: 0";
        }
        foreach(Transform child in transform)
        {
            if (PlayerPrefs.HasKey(child.name))
            {
                if (PlayerPrefs.GetInt(child.name) == 1)
                {
                    child.GetComponent<Image>().color = Color.white;
                    if (PlayerPrefs.HasKey("hatEquipped"))
                    {
                        if (PlayerPrefs.GetInt("hatEquipped") == child.transform.GetSiblingIndex()+1)
                        {
                            text = GameObject.Find("EQUIPPED");
                            text.transform.localPosition = child.transform.localPosition + new Vector3(40, -64, 0);
                        }
                    }
                    else
                    {
                        PlayerPrefs.SetInt("hatEquipped", 0);
                    }
                }
            }
        }
	}
	
}
