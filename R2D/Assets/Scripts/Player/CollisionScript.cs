using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
	public bool isGrounded;
	public int playerID;
    public Animator forthejumps;

	void Start()
	{

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Floor")
			isGrounded = true;
        forthejumps.SetBool("IsGrounded", false);
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Floor")
			isGrounded = false;
        forthejumps.SetBool("IsGrounded", true);

        //if (coll.gameObject.tag == "Player")
        // coll.gameObject.GetComponent<RigidBody2D>
    }
}
