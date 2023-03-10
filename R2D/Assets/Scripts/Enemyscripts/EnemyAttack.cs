using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;


	//Animator anim;
	GameObject player;
	PlayerHealth playerHealth;
	bool playerInRange;
	float timer;


	void Awake () {
		player = GameObject.Find("player1").gameObject;
		playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent<EnemyHealth>();
		//anim = GetComponent <Animator> ();
	}


	void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Player") {
			playerInRange = true;
        }
        if (other.gameObject.tag == "playerarm")
        {
            playerInRange = true;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<BoxCollider2D>(), other.gameObject.GetComponent<BoxCollider2D>(), true);
        }
    }

	void OnCollisionExit2D(Collision2D other) {
		if(other.gameObject.tag == "Player") {
			playerInRange = false;
		}
	}
    

	void Update () {

		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && playerInRange /*&&enemyHealth.currentHelath > 0*/){
			Attack ();
		}	}

	void Attack ()
	{
		timer = 0f;

		if(playerHealth.currentHealth > 0)
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}
}
