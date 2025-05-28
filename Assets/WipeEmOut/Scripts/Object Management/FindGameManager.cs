using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    [SerializeField] private KillManager kills;

    void Start()
    {
        kills = FindAnyObjectByType<KillManager>();       
    }

    public void AddZombieKill(int value)
    {
        kills.AddKillCount(value);
    }
}
