using UnityEngine;

public class CollectableBaseCoin : CollectableBase
{
    public int coinValue = 1;
    protected override void OnCollect()
    {
        base.OnCollect();
        CollectablesManager.Instance.AddCoin(coinValue);
    }
}
