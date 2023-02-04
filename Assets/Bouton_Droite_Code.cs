using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton_Droite_Code : MonoBehaviour
{

    private int WinScore = 20;
    private int WinScore2 = -20;
    public Score Scr;


    // Update is called once per frame
    public void ClickDroite()
    {

        Scr.score++;


        if (Scr.score >= WinScore)
        {
            Debug.Log("Player 1 Win");
        }
    }
    public void ClickGauche()
    {

        Scr.score--;


        if (Scr.score <= WinScore2)
        {
            Debug.Log("Player2 Win");

        }
    }

}
