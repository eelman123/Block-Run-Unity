using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // bool levelCompleted = false;
    bool levelLost = false;

    public float restartDelay = 2f;
    public float winDelay = 2f;

    public float levelDelay = 3f;

    public GameObject completeLevelUI;
    

    public void WinLevel()
    {
        Invoke("CompleteLevel", winDelay);
        Invoke("LoadNextScene", levelDelay);
    }

    public void EndGame()
    {

        if (levelLost == false)
        {

            levelLost = true;
            // Debug.Log("Game over");
            Invoke ("Restart", restartDelay);
        }


    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void LoadNextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
