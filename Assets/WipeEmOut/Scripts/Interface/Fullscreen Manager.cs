using UnityEngine;
using UnityEngine.UI;

public class FullscreenManager : MonoBehaviour
{
    [SerializeField] private Toggle toggle;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("fullscreen"))
        {
            //Since we can't save a bool in playerprefs, we'll use 1 for true and 0 for false
            toggle.isOn = Screen.fullScreen = PlayerPrefs.GetInt("fullscreen") > 0;
        }
    }

    public void FullscreenToggle(bool value)
    {
        Screen.fullScreen = value;
        Debug.Log("fullscreened");

        PlayerPrefs.SetInt("fullscreen", value ? 1 : 0);

        PlayerPrefs.Save();
    }
}
