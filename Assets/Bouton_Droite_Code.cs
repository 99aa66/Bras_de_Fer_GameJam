using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bouton_Droite_Code : MonoBehaviour
{

    private int WinScore = 10;
    private int WinScore2 = -10;
    [SerializeField] private Score Scr;
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
    [SerializeField] private GameObject Texte1;
    [SerializeField] private GameObject Texte2;
    private string Texte;

    // Update is called once per frame
    public void ClickDroite()
    {

        Scr.score++;


        if (Scr.score >= WinScore)
        {
            Debug.Log("Player 2 Win"); 
            Button1.SetActive(false);
            Button2.SetActive(false);
            Texte1.SetActive(true);
            Texte2.SetActive(true);

            Texte1.GetComponent<TextMeshProUGUI>().text = " DEFEAT ";
            Texte2.GetComponent<TextMeshProUGUI>().text = " WIN ";

        }
    }
    public void ClickGauche()
    {

        Scr.score--;
        

        if (Scr.score <= WinScore2)
        {
            Debug.Log("Player 1 Win");
            Button1.SetActive(false);
            Button2.SetActive(false);
            Texte1.SetActive(true);
            Texte2.SetActive(true);

            Texte1.GetComponent<TextMeshProUGUI>().text = " WIN ";
            Texte2.GetComponent<TextMeshProUGUI>().text = " DEFEAT ";

        }
    }

}
