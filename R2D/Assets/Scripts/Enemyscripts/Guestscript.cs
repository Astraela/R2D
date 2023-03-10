using UnityEngine;
using System.Collections;

public class Guestscript : MonoBehaviour
{
    private Transform target;
    public int moveSpeed;
    public int rotationSpeed;
    public Rigidbody2D woorigidbody2D;
    private GameObject player1;
    void Start()
    {
        player1 = GameObject.Find("player1");
        target = player1.transform;
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 dir = target.position - transform.position;
            // Only needed if objects don't share 'z' value.
            if (dir != Vector2.zero)
                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.FromToRotation(Vector2.right, dir),
                    rotationSpeed * Time.deltaTime);

            //Move Towards Target
            transform.position = Vector2.MoveTowards(transform.position, target.position,moveSpeed*Time.deltaTime);
           // transform.position += (target.position - transform.position).normalized * moveSpeed * Time.deltaTime;
        }
        woorigidbody2D.velocity = Vector2.zero;
    }
}