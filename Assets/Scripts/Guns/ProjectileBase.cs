using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    public Transform PlayerSide;
    public float speed = 25f;
    public Vector3 direction = Vector3.right;
    public float side = 1;
    public float lifeTime = 2.5f;
    public int damage = 5;

    private void Awake()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime * side);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Projétil Colidiu com: " + collision.gameObject.name);

        var enemy = collision.gameObject.GetComponent<EnemyBase>();

        if (enemy != null)
        {
            enemy.Damage(damage);
        }
    }
}
