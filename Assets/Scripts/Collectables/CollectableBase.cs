using UnityEngine;

public class CollectableBase : MonoBehaviour
{

    public string collectableTag = "Player";
    public ParticleSystem particleSystem;

    private void Awake()
    {
        if (particleSystem != null) particleSystem.transform.SetParent(null);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(collectableTag))
        {
            Collect();
        }
    }
    protected virtual void Collect()
    {
        Debug.Log("Coletou: " + gameObject.name);
        gameObject.SetActive(false);
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        if (particleSystem != null) particleSystem.Play();
    }

}
