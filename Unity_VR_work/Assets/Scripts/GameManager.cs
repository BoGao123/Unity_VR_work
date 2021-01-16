using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestarGame()
    {
        SceneManager.LoadScene("期末");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}