using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private Toggle soundsToggle;

    [SerializeField] private AudioControler audioControler;

    private void OnEnable()
    {
        musicToggle.isOn = Global.Music;
        soundsToggle.isOn = Global.Sounds;
        musicToggle.onValueChanged.AddListener(ChangeMusic);
        soundsToggle.onValueChanged.AddListener(ChangeSound);
    }

    private void ChangeMusic(bool value)
    {
        audioControler.EnableMusic(value);
    }
    private void ChangeSound(bool value) 
    {
        audioControler.EnableSounds(value);
    }

    private void OnDestroy()
    {
        musicToggle.onValueChanged.RemoveListener(ChangeMusic);
        soundsToggle.onValueChanged.RemoveListener(ChangeSound);
    }
}
