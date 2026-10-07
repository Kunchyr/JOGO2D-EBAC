using UnityEngine;

public class HealthBase : MonoBehaviour
{
    #region(Variables)
    public float HPmax = 100f;
    public float currentHP;
    public float damage = 10f;
    public bool isDead = false;
    public bool destroyOnDeath = false;
    #endregion(Variables)

    private void Awake()
    {   
        Init();
    }

    private void Init()
    {
        currentHP = HPmax;
        isDead = false;
    }
    public void TakeDamage(float damage)
    {
        if (isDead)
        {
            return;
        }
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Kill();
        }
    }
    private void Kill()
    {
        isDead = true;
        print("Morreu");
        if (destroyOnDeath)
        {
            Destroy(gameObject);
        }
    }
}
