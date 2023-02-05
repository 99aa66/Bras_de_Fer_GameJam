using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] public retur retur;

    public void StartLevel() 
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
    public void Update()
    {
        if (retur.check_P1 && retur.check_P2)
        {
            SceneManager.LoadScene("title screen");
        }
    }
    public void ReturnP1()
    {
        retur.check_P1 = true;
        
        Destroy(gameObject);

    }
    public void ReturnP2()
    {
        retur.check_P2 = true;
        
        Destroy(gameObject);
        

    }

}
