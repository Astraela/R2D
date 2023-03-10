using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public AudioSource deathClip;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	AudioSource playerAudio;
	public moveScript moveScript;

	bool isDead;
	bool damaged;

    private GameObject ServerScript;
    private WaveScript wavescript;
    private EndlessScript endlessscript;

    int heal = 0;

    void Awake(){
		currentHealth = startingHealth;

        ServerScript = GameObject.Find("Serverscripts");
        wavescript = ServerScript.GetComponent<WaveScript>();
        endlessscript = ServerScript.GetComponent<EndlessScript>();
    }

	
	// Update is called once per frame
	void Update () {
		if(damaged) {
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;

        if (wavescript.intermissionstart == true)
        {
            if (heal < 34)
            {               
                 heal++;
                 if (currentHealth < 100) {
                    currentHealth = currentHealth + 1;
                    healthSlider.value = currentHealth;
                }
            }
        }
        else
        {
            heal = 0;
        }


	}

	public void TakeDamage (int amount)
	{
		damaged = true;

		currentHealth -= amount;

		healthSlider.value = currentHealth;

		//playerAudio.Player ();

		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}

	 void Death ()
	{
		isDead = true;

        int highestwave = PlayerPrefs.GetInt("HighestWave");

        if (endlessscript.wave > highestwave) {
            PlayerPrefs.SetInt("HighestWave", endlessscript.wave);
            endlessscript.wave = 0;
        }

		//anim.SetTrigger ("Die");
		deathClip.Play ();
		//playerAudio.Player ();

		moveScript.enabled = false;

		// yield return new WaitForSeconds (10);
		//WaitForSeconds (10);
		StartCoroutine(Example());
		// ^ Laat hem buggen ^ //

		//SceneManager.LoadScene("GameOver");
	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("GameOver");
	}
}
