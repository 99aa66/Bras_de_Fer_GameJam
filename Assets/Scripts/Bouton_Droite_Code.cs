using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bouton_Droite_Code : MonoBehaviour
{

    private int WinScore = 10;
    private int WinScore2 = -10;
    
    private int ScoreP1 = 0;
    private int ScoreP2 = 0;

    private float Click_Sec_P1 = 0;
    private float Click_Sec_P2 = 0;

    [SerializeField] private Score Scr;
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
    [SerializeField] private GameObject Button_Retour1;
    [SerializeField] private GameObject Button_Retour2;
    [SerializeField] private GameObject Texte1;
    [SerializeField] private GameObject Texte2;
    [SerializeField] private GameObject Audio;
    [SerializeField] private GameObject Timer;


    [SerializeField] private GameObject DominG;
    [SerializeField] private GameObject DominD;
    [SerializeField] private GameObject Egal;

    [SerializeField] private GameObject FinD;
    [SerializeField] private GameObject FinG;

    [SerializeField] private GameObject Sifflet;


    private string Texte;

    [SerializeField] private Timer Tim;

    private double Resultat1 = 0;
    private double Resultat2 = 0;


    // Update is called once per frame
    public void ClickDroite()
    {

        Scr.score++;
        ScoreP2++;

        if (Scr.score >= WinScore)
        {
            Debug.Log("Player 2 Win"); 
            Button1.SetActive(false);
            Button2.SetActive(false);
            Timer.SetActive(false);
            Button_Retour1.SetActive(true);
            Button_Retour2.SetActive(true);

            Texte1.SetActive(true);
            Texte2.SetActive(true);

            Texte1.GetComponent<TextMeshProUGUI>().text = " DEFEAT ";
            Texte2.GetComponent<TextMeshProUGUI>().text = " WIN ";
            Destroy(Audio);

            DominG.SetActive(false);
            DominD.SetActive(false);
            Egal.SetActive(false);
            FinD.SetActive(true);
            Sifflet.SetActive(true);
            Sifflet.SetActive(true);

            Click_Sec_P2 = ScoreP2 / Tim.timeValue;
            Click_Sec_P1 = ScoreP1 / Tim.timeValue;

            Resultat1 = Math.Round(Click_Sec_P1, 2);
            Resultat2 = Math.Round(Click_Sec_P2, 2);



        }
    }
    public void ClickGauche()
    {

        Scr.score--;
        ScoreP1++;
        
        if (Scr.score <= WinScore2)
        {
            Debug.Log("Player 1 Win");
            Button1.SetActive(false);
            Button2.SetActive(false);
            Timer.SetActive(false);
            Button_Retour1.SetActive(true);
            Button_Retour2.SetActive(true);

            Texte1.SetActive(true);
            Texte2.SetActive(true);

            Texte1.GetComponent<TextMeshProUGUI>().text = " WIN ";
            Texte2.GetComponent<TextMeshProUGUI>().text = " DEFEAT ";
            Destroy(Audio);

            DominG.SetActive(false);
            DominD.SetActive(false);
            Egal.SetActive(false);
            FinG.SetActive(true);
            Sifflet.SetActive(true) ;

            
            Click_Sec_P1 = ScoreP1 / Tim.timeValue;
            Click_Sec_P2 = ScoreP2 / Tim.timeValue;

            Resultat1 = Math.Round(Click_Sec_P1, 2);
            Resultat2 = Math.Round(Click_Sec_P2, 2);



        }
        
    }
    public void Update()
    {
        
        if (Tim.timeValue == 0)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button_Retour1.SetActive(true);
            Button_Retour2.SetActive(true);

            Texte1.SetActive(true);
            Texte2.SetActive(true);

            Texte1.GetComponent<TextMeshProUGUI>().text = " DRAW ";
            Texte2.GetComponent<TextMeshProUGUI>().text = " DRAW ";
            Destroy(Audio);
            Sifflet.SetActive(true);

            Click_Sec_P1 = ScoreP1 / 9;
            Click_Sec_P2 = ScoreP2 / 9;

            Resultat1 = Math.Round(Click_Sec_P1, 2);
            Resultat2 = Math.Round(Click_Sec_P2, 2);

            

        }

        if (Scr.score > 3 && Scr.score <= 9)
        {
            DominG.SetActive(true);
            DominD.SetActive(false);
            Egal.SetActive(false);

        }
        else if (Scr.score < -3 && Scr.score >= -9)
        {
            DominD.SetActive(true);
            DominG.SetActive(false);
            Egal.SetActive(false);
        }
        else
        {
            Egal.SetActive(true);
            DominD.SetActive(false);
            DominG.SetActive(false);
        }

        
    }


}
