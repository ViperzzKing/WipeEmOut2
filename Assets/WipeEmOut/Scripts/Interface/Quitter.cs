using UnityEngine;

public class Quitter : MonoBehaviour
{
    public void Quiting()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
