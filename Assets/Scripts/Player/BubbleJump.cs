using UnityEngine;

public class BubbleJump : MonoBehaviour
{
    public GameObject objeto;
    public float tempo;

    void Start()
    {
        objeto.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objeto.SetActive(true);
            tempo = 1f;
        }
        else if (tempo > 0)
        {
            tempo -= Time.deltaTime;

            if (tempo <= 0)
            {
                objeto.SetActive(false);
            }
        }
    }
}