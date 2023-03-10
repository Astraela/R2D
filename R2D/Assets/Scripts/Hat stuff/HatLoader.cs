using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq.Expressions;

public class HatLoader : MonoBehaviour {

    public Sprite apple;
    public Sprite Battalion;
    public Sprite beautifulhair;
    public Sprite Blockytophat;
    public Sprite BuddyBCap;
    public Sprite Doge;
    public Sprite Donuthat;
    public Sprite Equino;
    public Sprite fedora;
    public Sprite GreenBCap;
    public Sprite ObviousSpyCap;
    public Sprite PaperHat;
    public Sprite PilotHat;
    public Sprite SantaHat;
    public Sprite Socialite;
    public Sprite SovietUshanka;
    public Sprite TopHat;
    public Sprite TrafficCone;

    private SpriteRenderer sr;
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        if (PlayerPrefs.HasKey("hatEquipped"))
        {
            switch (PlayerPrefs.GetInt("hatEquipped"))
            {
                case 1:
                    sr.sprite = Battalion;
                    break;
                case 2:
                    sr.sprite = apple;
                    break;
                case 3:
                    sr.sprite = beautifulhair;
                    break;
                case 4:
                    sr.sprite = Blockytophat;
                    break;
                case 5:
                    sr.sprite = Doge;
                    break;
                case 6:
                    sr.sprite = Donuthat;
                    break;
                case 7:
                    sr.sprite = BuddyBCap;
                    break;
                case 8:
                    sr.sprite = Equino;
                    break;
                case 9:
                    sr.sprite = fedora;
                    break;
                case 10:
                    sr.sprite = GreenBCap;
                    break;
                case 11:
                    sr.sprite = ObviousSpyCap;
                    break;
                case 12:
                    sr.sprite = PaperHat;
                    break;
                case 13:
                    sr.sprite = PilotHat;
                    break;
                case 14:
                    sr.sprite = SantaHat;
                    break;
                case 15:
                    sr.sprite = Socialite;
                    break;
                case 16:
                    sr.sprite = SovietUshanka;
                    break;
                case 17:
                    sr.sprite = TopHat;
                    break;
                case 18:
                    sr.sprite = TrafficCone;
                    break;
            }
        }
	}
}
