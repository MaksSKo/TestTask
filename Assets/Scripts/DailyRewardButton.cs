using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewardButton : MonoBehaviour
{
    [SerializeField] private Button thisButton;

    private string currentDate;
    private bool isRewardGained;

    public static event Action<int> OnRewardGained;

    public void Initialize(bool value)
    {
        if (!value)
        {
            thisButton.interactable = false;
            return;
        }

        currentDate = DateTime.Now.Date.ToString();
        isRewardGained = PlayerPrefs.GetInt($"RewardDay{currentDate}") == 1 ? true : false;
        TryDisableButton();
    }

    public void CollectReward(int rewardAmount)
    {
        Global.Currency += rewardAmount;
        PlayerPrefs.SetInt($"RewardDay{currentDate}", 1);
        isRewardGained = true;
        OnRewardGained?.Invoke(rewardAmount);
        TryDisableButton();
    }

    private void TryDisableButton()
    {
        if (!isRewardGained)
        {
            return;
        }

        thisButton.interactable = false;
    }
}
