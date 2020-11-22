using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SzeneM : MonoBehaviour
{
   
    public void PlayGame(){

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void RestartGame()
    {

        SceneManager.LoadScene("InGame");
    }

    public void QuitGame(){

            Application.Quit();
        
    }

}
