using UnityEngine;
using TMPro;

public class KillManager : MonoBehaviour
{
    // Reference to the TMP text
    [Header("References")]
    [SerializeField] TMP_Text kills;

    // current zombies you have killed
    [Header("Killed Enemies")]
    [SerializeField] private int killCount;

    // on start reset kills to 0

    private void Start()
    {
        killCount = 0;
        kills.text = "Kills: " + killCount.ToString();
    }

    // condition to run whenever you kill a enemy

    public void AddKillCount(int value)
    {
    // add a counter to the current enemies you killed
        killCount += value;
        // update the text to match the counter
        kills.text = "Kills: " + killCount.ToString();
    }


}
