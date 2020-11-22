using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {

        SceneManager.LoadScene("InGame");
    }

    public void QuitGame(){


        Application.Quit();
    }
}
