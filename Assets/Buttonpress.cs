using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Buttonpress : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Main");
    }
    public void endPlay()
    {
        SceneManager.LoadScene("exit");
    }
    public void StopPlay()
    {
        SceneManager.LoadScene("exit");
    }
    public void PlayAgain()
    {
       SceneManager.LoadScene("start");
    }
    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
