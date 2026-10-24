using UnityEngine;
using TMPro;

public class CollectablesManager : MonoBehaviour
{
    public static CollectablesManager Instance;
    public int coins = 0;
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
        coins = 0;
    }
    public void AddCoin(int amount = 1)
    {
        coins+= amount;
        textHudCoinText.text = "x " + coins.ToString();
        Debug.Log("Coins: " + coins);
    }
}
