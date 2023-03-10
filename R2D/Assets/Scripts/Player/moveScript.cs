using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour
{
	public GameObject player1;



	private Rigidbody2D rb1;

	private CollisionScript collisionScript1;
    public Animator playeranimation;
	void Start()
	{
		//GetComponent on the player to cache the spriteRenderer
		rb1 = player1.GetComponent<Rigidbody2D>();

		collisionScript1 = player1.GetComponent<CollisionScript> ();
	}

	// Update is called once per frame
	void Update()
	{
		    

		#region GetKey WASD Player 1
		if (Input.GetKey(KeyCode.A))
		{
			rb1.AddForce(new Vector2(-50, 0));
			if(rb1.velocity.x < -8)
			{
				rb1.velocity = new Vector2(-8, rb1.velocity.y);
			}
            
            playeranimation.SetBool("Walking",true);
		}
		if (Input.GetKeyUp(KeyCode.A))
		{
			rb1.velocity = new Vector2(0, rb1.velocity.y);
            playeranimation.SetBool("Walking", false);
        }
		if (Input.GetKey(KeyCode.D))
		{
			rb1.AddForce(new Vector2(50, 0));
			if(rb1.velocity.x > 8)
			{
				rb1.velocity = new Vector2(8, rb1.velocity.y);
            }
            playeranimation.SetBool("Walking", true);
        }
		if (Input.GetKeyUp(KeyCode.D))
		{
			rb1.velocity = new Vector2(0, rb1.velocity.y);
            playeranimation.SetBool("Walking", false);
        }
		if (Input.GetKeyDown(KeyCode.Space) && collisionScript1.isGrounded && rb1.velocity.y <= 0.01f)
		{
			rb1.AddForce(new Vector2(0, 500));
		}
		if (Input.GetKey(KeyCode.S))
		{
			rb1.AddForce(new Vector2(0, -5));
		}

		#endregion
	}

	void FixedUpdate()
	{
		//===== Use this for everything physics related
	}
}
