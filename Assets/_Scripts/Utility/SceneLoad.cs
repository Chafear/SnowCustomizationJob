using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
