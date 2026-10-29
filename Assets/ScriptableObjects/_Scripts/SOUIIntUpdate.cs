using UnityEngine;
using TMPro;

public class SOUIIntUpdate : MonoBehaviour
{
    public SOInt soInt;
    public TextMeshProUGUI uiTextValue;

    private void Start()
    {
        uiTextValue.text = "x " + soInt.value.ToString();
    }
    void Update()
    {
        uiTextValue.text = "x " + soInt.value.ToString();
    }
}
