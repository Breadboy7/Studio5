using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHooks : MonoBehaviour
{
    public string nextScene;

    public void nextSceneManual()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void LoadNextScene()
    {
        SceneHandler.Instance.LoadNextScene();
    }

    public void ExitToMenu()
    {
        SceneHandler.Instance.LoadNextScene();
    }
}
