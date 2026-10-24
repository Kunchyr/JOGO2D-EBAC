using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public HealthBase healthBase;
    public float damage = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colidiu com: " + collision.gameObject.name);
        var health = collision.gameObject.GetComponent<HealthBase>();

        if (health != null)
        {
        health.TakeDamage(damage);
        }
    }

    public void Damage(float damage)
    {
        healthBase.TakeDamage(damage);
    }

}
