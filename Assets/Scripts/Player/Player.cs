using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 friction = new Vector2(0.1f, 0);
    public float speed = 5f;
    public float jumpForce = 10f;

    void Update()
    {
    Movement();
    Jump();
    Sprint();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.linearVelocity = new Vector2(-speed, rigidbody2D.linearVelocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.linearVelocity = new Vector2(+speed, rigidbody2D.linearVelocity.y);
        }

        if(rigidbody2D.linearVelocity.x > 0)
        {
            rigidbody2D.linearVelocity -= new Vector2(friction.x, friction.y);
        }
        else if (rigidbody2D.linearVelocity.x < 0)
        {
            rigidbody2D.linearVelocity += new Vector2(friction.x, friction.y);
        }
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x, jumpForce);
        }
    }   
    private void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
    }
}
