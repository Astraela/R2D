using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class menubtnscript : MonoBehaviour {
    public Canvas Modes;
    public Canvas Main;
    public Button Medium;
    public Button Back;
    public Animator Mediumam;
    public Animator optionam;
    public Animator exitam;
    public void mode()
    {
        optionam.SetBool("startc", true);
        exitam.SetBool("startc", true);
        Main.enabled = false;
        Modes.enabled = true;
        Mediumam.SetBool("startc", false);
        Back.transform.position = new Vector3(115, 1040, 0);

    }
    public void close()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
