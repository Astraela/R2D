using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class savingscripts : MonoBehaviour {


    public void savestorymode()
    {
        // Create an instance of StreamWriter to write text to a file.
        // The using statement also closes the StreamWriter.
        PlayerPrefs.SetString("mode","StoryMode");
    }
    public void savefreemode()
    {
        // Create an instance of StreamWriter to write text to a file.
        // The using statement also closes the StreamWriter.
        PlayerPrefs.SetString("mode", "FreeMode");
    }
}
