using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backbtn : MonoBehaviour {

    public Animator Mediumam;
    public Animator Hardam;
    public Animator optionam;
    public Animator exitam;
    public Canvas Modes;
    public Canvas Main;
    public Button Back;
    public Button options;
    public Button exit;
    private IEnumerator WaitForAnimation(Animation animation)
    {
        do
        {
            yield return null;
        } while (animation.isPlaying);
    }
    public void back()
    {
        options.transform.localPosition = new Vector3(0, 0, 0);
        exit.transform.localPosition = new Vector3(0, 0, 0);
        Mediumam.SetBool("startc", true);
        Hardam.SetBool("startc", true);
        Modes.enabled = false;
        Main.enabled = true;
        optionam.SetBool("startc", false);
        exitam.SetBool("startc", false);
    Back.transform.position = new Vector2(0,1123);
        
    }
    public void Start()
    {

    }
}
