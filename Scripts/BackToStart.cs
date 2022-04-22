using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }
}
