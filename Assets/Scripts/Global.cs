using UnityEngine;

public static class Global
{
    private static int currency;
    private static bool music;
    private static bool sounds;
    private static int lastAvailableLevel;
    private static int lastOpenedLevel;
    public static int Currency
    {
        get 
        { 
            currency = PlayerPrefs.GetInt("Currency", 0);
            return currency;
        }
        set 
        { 
            currency = value;
            PlayerPrefs.SetInt("Currency", currency);
        }
    }

    public static bool Music 
    {
        get 
        {
            music = PlayerPrefs.GetInt("Music", 1) == 1 ? true : false;
            return music; 
        }
        set 
        {
            music = value;
            PlayerPrefs.SetInt("Music", value == true ? 1 : 0);
        }
    }

    public static bool Sounds
    {
        get
        {
            sounds = PlayerPrefs.GetInt("Sounds", 1) == 1 ? true : false;
            return sounds;
        }
        set
        {
            sounds = value;
            PlayerPrefs.SetInt("Sounds", value == true ? 1 : 0);
        }
    }

    public static int LastAvailableLevel 
    {
        get 
        {
            lastAvailableLevel = PlayerPrefs.GetInt("LastLevelAvailable", 1);
            return lastAvailableLevel;
        }
        set 
        {
            if (value < lastAvailableLevel)
            {
                return;
            }

            lastAvailableLevel = value;
            PlayerPrefs.SetInt("LastLevelAvailable", value);
        }
    }

    public static int LastOpenedLevel 
    {
        get { return lastOpenedLevel; }
        set { lastOpenedLevel = value; }
    }
}
