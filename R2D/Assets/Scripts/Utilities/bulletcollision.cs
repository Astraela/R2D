using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletcollision : MonoBehaviour {
    
	private EnemyHealth EnemyHealth;
    private StBossScript stbossscript;
    public ShootScript shootscript;

    private void Start()
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());

    }

	private void OnBecameInvisible () {
        aaaaa();
	}
    void aaaaa()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Floor" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            EnemyHealth.health -= shootscript.damage;
            //Debug.Log(EnemyHealth.health);    
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Boss")
        {
            stbossscript = collision.gameObject.GetComponent<StBossScript>();
            stbossscript.health -= shootscript.damage;
            //Debug.Log(EnemyHealth.health);
            Destroy(gameObject);

        }

    }
}
