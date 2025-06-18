using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private string channelName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey(channelName))
        {
            VolumeManager.SetVolume(channelName, PlayerPrefs.GetFloat(channelName));

            GetComponent<Slider>().value = PlayerPrefs.GetFloat(channelName);
        }
    }

    public void SetVolume(float volume)
    {
        VolumeManager.SetVolume(channelName, volume);

        PlayerPrefs.SetFloat(channelName, volume);
        PlayerPrefs.Save();
    }
}
