    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour {

    public GameObject bullet;
	public AudioSource pistolSound;
	public AudioSource reloadSound;
    public GameObject arm;
    Text CurrentAmmo;

    public float speed = 5.0f;
    public float fireRate = 0.5f;
    public float maxAmmo = 12;
    public float reloadTime = 2;
    public int shotAmount = 1;
    public int spread = 10;
    public float damage = 10;

    float fr;
    float CurrentBullets;
    float rt;
    bool reload = false;

	AudioSource gunAudio;

    // Use this for initialization
    void Start () {
        CurrentAmmo = GameObject.Find("AmmoTXT").GetComponent<Text>();
        CurrentAmmo.text = "Ammo: " + CurrentBullets + "   ";
        fr = fireRate;
        CurrentBullets = maxAmmo;
        rt = reloadTime;
    }

    void Reloading()
    {
        reloadTime -= Time.deltaTime;
        if (reloadTime <= 0)
        {
            reload = false;
            CurrentBullets = maxAmmo;
            CurrentAmmo.text = "Ammo: " + CurrentBullets + "   ";
            reloadTime = rt;
        }
    }


    // Update is called once per frame
    void Update () {

        if (CurrentBullets == 0 || (Input.GetKeyDown(KeyCode.R)))
        {
            CurrentBullets = 0;
			reloadSound.Play ();
            CurrentAmmo.text = "Ammo: ...   ";
			reload = true;
        }

        if (reload)
        {
            Reloading();
        }

        fireRate -= Time.deltaTime;

		if (Input.GetButton("Fire1") && fireRate <= 0)
        {
            fireRate = fr;

            if (CurrentBullets > 0)
            {

                for (int i = 0; i < shotAmount; i++) {

                    GameObject projectile = (GameObject)GameObject.Instantiate(bullet, transform.position, arm.transform.rotation);
                    projectile.transform.eulerAngles = new Vector3(projectile.transform.eulerAngles.x, projectile.transform.eulerAngles.y, projectile.transform.eulerAngles.z + Random.Range(-spread,spread));
                    projectile.GetComponent<bulletcollision>().shootscript = this;

                    projectile.GetComponent<Rigidbody2D>().AddForce(projectile.transform.right * speed);
                }

                CurrentBullets--;
                CurrentAmmo.text = "Ammo: " + CurrentBullets + "   ";
                pistolSound.Play();

            }
        }
        
    }
}
