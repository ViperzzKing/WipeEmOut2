using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void LoadSceneByBuildIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
