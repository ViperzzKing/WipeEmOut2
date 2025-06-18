using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    [Header("References")]
    public AudioMixer audioMixer;

    public static AudioMixer staticMixer;

    private void Awake()
    {
        staticMixer = audioMixer;
    }

    public static void SetVolume(string channelName, float Volume)
    {
        staticMixer.SetFloat(channelName, Volume);
    }
}
