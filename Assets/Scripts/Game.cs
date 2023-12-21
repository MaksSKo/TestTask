using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;

    private void Start()
    {
        levelText.text = $"Level {Global.LastOpenedLevel}";
    }

    public void FinishLevel()
    {
        if (Global.LastAvailableLevel <= Global.LastOpenedLevel)
        {
            Global.LastAvailableLevel += 1;
        }

        SceneManager.LoadScene(0);
    }
}
