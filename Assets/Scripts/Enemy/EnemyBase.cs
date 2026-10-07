using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float damage = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colidiu com: " + collision.name);
        var health = collision.GetComponent<HealthBase>();

        if (health != null)
        {
        health.TakeDamage(damage);
        }
    }
}
