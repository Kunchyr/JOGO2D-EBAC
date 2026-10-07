using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Vector2 velocity;
    public float speed;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.linearVelocity = new Vector2(-speed, rigidbody2D.linearVelocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.linearVelocity = new Vector2(+speed, rigidbody2D.linearVelocity.y);
        }
    }
}
