using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private int levelNumber;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private string gameSceneName;
    [SerializeField] private Button thisButton;

    private bool isUnlocked;

    public void Initialize(int lastAvailableLevel)
    {
        isUnlocked = lastAvailableLevel >= levelNumber;
        level.text = levelNumber.ToString();

        if (!isUnlocked)
        {
            thisButton.interactable = false;
        }
    }

    public void StartLevel()
    {
        Global.LastOpenedLevel = levelNumber;
        SceneManager.LoadScene(gameSceneName);
    }
}
