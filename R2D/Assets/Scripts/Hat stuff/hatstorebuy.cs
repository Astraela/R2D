using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class hatstorebuy : MonoBehaviour {
    private GameObject text;
    private int credits;
    private int check;
    private int price;
    private int id;
    public void GetClicked(string info)
    {
        string[] tokens = info.Split(',');
        id = Convert.ToInt32(tokens[1]);
        price = Convert.ToInt32(tokens[0]);
        text = GameObject.Find("EQUIPPED");
        if (PlayerPrefs.HasKey("HatButton" + id.ToString()))
        {
            Debug.Log(PlayerPrefs.GetInt("hatEquipped"));
            if (PlayerPrefs.GetInt("hatEquipped") == id)
            {
                PlayerPrefs.SetInt("hatEquipped", 0);
                text.transform.localPosition = new Vector3(-1223, 250, 0);
            }
            else
            {
                PlayerPrefs.SetInt("hatEquipped", id);
                text.transform.localPosition = transform.localPosition + new Vector3(40, -64, 0);
            }
        }
        else
        {
            if (PlayerPrefs.HasKey("Credits"))
            {
                credits = PlayerPrefs.GetInt("Credits");
                if (credits >= price)
                {
                    PlayerPrefs.SetInt("Credits", credits - price);
                    credits = credits - price;
                    PlayerPrefs.SetInt("HatButton" + id.ToString(), 1);
                    gameObject.GetComponent<Image>().color = Color.white;
                }
            }
        }
    }
}
