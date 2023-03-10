using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pointscript : MonoBehaviour
{
    public SpriteRenderer sidearm;
    public SpriteRenderer sideleg;
    public SpriteRenderer mainleg;
    public SpriteRenderer Head;
    public SpriteRenderer glock;
    public SpriteRenderer hat;
    public GameObject gameobject;
    private Animator an;
    public Sprite whiteequinox;
    public Sprite blackequinox;
    private void Start()
    {
        an = transform.parent.parent.parent.GetComponent<Animator>();
    }
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if ((angle >= 0.0 && angle <= 90.0) || (angle <= 0.0 && angle >= -90.0))
        {
            Head.flipX = false;
            glock.flipY = false;
            an.SetBool("flipped", false);
            if (hat.sprite.name == "EquinoxBlackSide")
            {
                hat.sprite = whiteequinox;
                hat.flipX = false;
            }else if (hat.sprite.name != "EquinoxWhiteSide")
            {
                hat.flipX = true;
            }
            
        }
        if ((angle >= 90.0 && angle <= 180.0) || (angle <= -90.0 && angle >= -180.0))
        {
            Head.flipX = true;
            glock.flipY = true;
            an.SetBool("flipped", true);
            if (hat.sprite.name == "EquinoxWhiteSide")
            {
                hat.sprite = blackequinox;
            }
            hat.flipX = false;
        }

    }
    
}