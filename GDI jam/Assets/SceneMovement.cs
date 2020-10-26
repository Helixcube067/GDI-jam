using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class SceneMovement : MonoBehaviour
{
    /* Contains all of the scene loading functions to move form scene to scene
     */ 
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject loadingScreen;
    public Slider slider;
    public GameObject endScreen;
    public TextMeshProUGUI progressText;
    public GameObject backgroundScreen;
    public GameObject otherScreen;

    #region Scene changers
    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void GameOver(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void EndGame() 
    {
        Time.timeScale = 0f;
        endScreen.SetActive(true);
        backgroundScreen.SetActive(false);
    }
    #endregion

    public void LoadLevel(string sceneName)
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadAsyncly(sceneName));
    }

    IEnumerator LoadAsyncly(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);
        otherScreen.SetActive(false);

        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            //Debug.Log(operation.progress);
            slider.value = progress;
            progressText.text = "Loading..." + progress * 100f + "%";
            yield return null;
        }
    }
}
