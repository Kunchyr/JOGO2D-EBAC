using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody2D;
    public Vector2 friction;
    public float speed = 5f;
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    public float jumpForce = 10f;
    public int direction;

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
            rigidbody2D.transform.localScale = new Vector3(1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(-speed, rigidbody2D.linearVelocity.y);
            animator.SetBool("isRun", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.transform.localScale = new Vector3(-1, 1, 1);
            rigidbody2D.linearVelocity = new Vector2(+speed, rigidbody2D.linearVelocity.y);
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }

        if(rigidbody2D.linearVelocity.x > 0)
        {
            rigidbody2D.linearVelocity += new Vector2(-.5f, 0);
        }
        else if (rigidbody2D.linearVelocity.x < 0)
        {
            rigidbody2D.linearVelocity -= new Vector2(-.5f, 0);
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
            speed = sprintSpeed;
            animator.speed = 2f;
    }
        else
        {
            speed = walkSpeed;
            animator.speed = 1f;
    }
    }
}
