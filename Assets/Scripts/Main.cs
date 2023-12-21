using TMPro;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currency;

    private void Update()
    {
        currency.text = Global.Currency.ToString();
    }
}
