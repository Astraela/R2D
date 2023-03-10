using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLoader : MonoBehaviour
{
    private int gunid;
    private ShootScript ss;
    public Sprite glock;
    public Sprite spas;
    public Sprite inter;
    public Sprite ak;
    public Sprite aug;
    public Sprite uzi;
    public Sprite revolver;
    public Sprite m60;
    // Use this for initialization
    void Start()
    {
        ss = GetComponent<ShootScript>();
        if (PlayerPrefs.HasKey("GunEquip"))
        {
            gunid = PlayerPrefs.GetInt("GunEquip");

        }
        else
        {
            gunid = 1;
        }
        switch (gunid)
        {
            case 1://Glock 17
                ss.speed = 1500;
                ss.fireRate = 0.5f;
                ss.maxAmmo = 12;
                ss.reloadTime = 2;
                ss.shotAmount = 1;
                ss.spread = 5;
                ss.damage = 5;
                transform.parent.GetComponent<SpriteRenderer>().sprite = glock;
                break;
            case 5://Spas 12
                ss.speed = 2000;
                ss.fireRate = 1.2f;
                ss.maxAmmo = 8;
                ss.reloadTime = 4;
                ss.shotAmount = 12;
                ss.spread = 10;
                ss.damage = 3;
                transform.parent.GetComponent<SpriteRenderer>().sprite = spas;
                break;
            case 7://Intervention
                ss.speed = 2500;
                ss.fireRate = 2f;
                ss.maxAmmo = 5;
                ss.reloadTime = 3;
                ss.shotAmount = 1;
                ss.spread = 1;
                ss.damage = 120;
                transform.parent.GetComponent<SpriteRenderer>().sprite = inter;
                break;
            case 4://Ak-47
                ss.speed = 2200;
                ss.fireRate = 0.15f;
                ss.maxAmmo = 35;
                ss.reloadTime = 2.2f;
                ss.shotAmount = 1;
                ss.spread = 4;
                ss.damage = 3;
                transform.parent.GetComponent<SpriteRenderer>().sprite = ak;
                break;
            case 6://Aug
                ss.speed = 1800;
                ss.fireRate = 0.1f;
                ss.maxAmmo = 45;
                ss.reloadTime = 2.2f;
                ss.shotAmount = 1;
                ss.spread = 1;
                ss.damage = 2;
                transform.parent.GetComponent<SpriteRenderer>().sprite = aug;
                break;
            case 3://Uzi
                ss.speed = 2500;
                ss.fireRate = 0.08f;
                ss.maxAmmo = 30;
                ss.reloadTime = 1.2f;
                ss.shotAmount = 1;
                ss.spread = 10;
                ss.damage = 1.5f;
                transform.parent.GetComponent<SpriteRenderer>().sprite = uzi;
                break;
            case 2://Revolver
                ss.speed = 1500;
                ss.fireRate = 1f;
                ss.maxAmmo = 6;
                ss.reloadTime = 2.8f;
                ss.shotAmount = 1;
                ss.spread = 7;
                ss.damage = 10;
                transform.parent.GetComponent<SpriteRenderer>().sprite = revolver;
                break;
            case 8://M60
                ss.speed = 2000;
                ss.fireRate = 0.15f;
                ss.maxAmmo = 60;
                ss.reloadTime = 5;
                ss.shotAmount = 1;
                ss.spread = 15;
                ss.damage = 3;
                transform.parent.GetComponent<SpriteRenderer>().sprite = m60;
                break;
            case 9://OP HACKERS AUTOGUN
                ss.speed = 5000;
                ss.fireRate = 0.001f;
                ss.maxAmmo = 999;
                ss.reloadTime = 0.01f;
                ss.shotAmount = 3;
                ss.spread = 6;
                ss.damage = 5;
                transform.parent.GetComponent<SpriteRenderer>().sprite = m60;
                break;
            case 10://OP HACKERS SNIPERGUN
                ss.speed = 5000;
                ss.fireRate = 0.001f;
                ss.maxAmmo = 1;
                ss.reloadTime = 0.001f;
                ss.shotAmount = 1;
                ss.spread = 1;
                ss.damage = 1000;
                transform.parent.GetComponent<SpriteRenderer>().sprite = inter;
                break;
        }
    }
}
