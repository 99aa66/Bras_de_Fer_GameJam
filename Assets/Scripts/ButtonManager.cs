using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartLevel() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void Return()
    {
        SceneManager.LoadScene("title screen");
    }
}
