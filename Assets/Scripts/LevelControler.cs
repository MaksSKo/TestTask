using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControler : MonoBehaviour
{
    [SerializeField] private List<Level> levels;

    public void Start()
    {
        levels.ForEach(level => level.Initialize(Global.LastAvailableLevel));
    }
}
