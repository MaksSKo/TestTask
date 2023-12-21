using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardControler : MonoBehaviour
{
    [SerializeField] private GameObject rewardView;
    [SerializeField] private Slider progress;
    [SerializeField] private TextMeshProUGUI rewardAmount;
    [SerializeField] private TextMeshProUGUI daysText;
    [SerializeField] private List<DailyRewardButton> rewardButtons;
    private int days;

    public void OnEnable()
    {
        days = PlayerPrefs.GetInt("Days", 0);
        progress.value = days;
        daysText.text = $"{days} / {rewardButtons.Count}";

        for (int i = 0; i < rewardButtons.Count; i++)
        {
            rewardButtons[i].Initialize(days >= i);
        }

        DailyRewardButton.OnRewardGained += ShowRewardView;
    }

    public void ShowRewardView(int rewardAmount)
    {
        rewardView.SetActive(true);
        this.rewardAmount.text = rewardAmount.ToString();
        days++;
        PlayerPrefs.SetInt("Days", days);
        progress.value = days;
        daysText.text = $"{days} / {rewardButtons.Count}";
    }

    private void OnDisable()
    {
        DailyRewardButton.OnRewardGained -= ShowRewardView;
    }
}
