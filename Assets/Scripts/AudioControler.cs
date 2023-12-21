using UnityEngine;

public class AudioControler : MonoBehaviour
{
    [SerializeField] private AudioSource musicPlayer;
    [SerializeField] private AudioSource soundPlayer;

    private void Start()
    {
        EnableMusic(Global.Music);
        EnableSounds(Global.Sounds);
    }

    public void PlaySound(AudioClip soundClip)
    {
        soundPlayer.PlayOneShot(soundClip);
    }

    public void EnableSounds(bool value)
    {
        soundPlayer.mute = !value;
        Global.Sounds = value;
    }

    public void EnableMusic(bool value)
    {
        if (value) musicPlayer.Play();
        else musicPlayer.Stop();
        Global.Music = value;
    }
}
