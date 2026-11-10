using UnityEngine;

public class BubbleRun : MonoBehaviour
{
    public GameObject objeto;
    public float tempo;

    void Start()
    {
        objeto.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
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