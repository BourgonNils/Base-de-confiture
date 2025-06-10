
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public static SceneManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }


    public void ReloadCurrentScene()
    {
        string currentSceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
    }


    public void LoadNextScene()
    {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("Derni�re sc�ne atteinte. Aucune sc�ne suivante � charger.");
        }
    }

    public void LoadScene(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public bool IsLastScene()
    {
        // R�cup�re l'index de la sc�ne actuelle
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;

        // R�cup�re le nombre total de sc�nes dans la build
        int totalScenesInBuild = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;

        // V�rifie si l'index de la sc�ne actuelle est �gal � l'index de la derni�re sc�ne
        return currentSceneIndex == totalScenesInBuild - 1;
    }


}
