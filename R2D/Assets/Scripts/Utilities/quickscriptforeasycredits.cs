using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickscriptforeasycredits : MonoBehaviour {

    public void clickd(int ammount)
    {
        PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits")+ammount);
    }
}
