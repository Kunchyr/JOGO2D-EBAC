using UnityEngine;
using TMPro;

public class CollectablesManager : MonoBehaviour
{
    public static CollectablesManager Instance;
    public SOInt coins;
    public TMP_Text textHudCoinText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Reset();
    }
    private void Reset()
    {
        coins.value = 0;
    }
    public void AddCoin(int amount = 1)
    {
        coins.value += amount;
        textHudCoinText.text = "x " + coins.value.ToString();
        Debug.Log("Coins: " + coins.value);
    }
}
