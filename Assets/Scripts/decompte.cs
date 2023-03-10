using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decompte : MonoBehaviour
{

    [SerializeField] private GameObject Bouton1;
    [SerializeField] private GameObject Bouton2;
    [SerializeField] private GameObject Bouton_Ret1;
    [SerializeField] private GameObject Bouton_Ret2;
    [SerializeField] private GameObject Timer;
    [SerializeField] private GameObject Texte1;
    [SerializeField] private GameObject Texte2;
    [SerializeField] private GameObject Bulle_carotte;
    [SerializeField] private GameObject Bulle_citrouille;
    [SerializeField] private GameObject Anim_Fond;
    [SerializeField] private GameObject Aide;
    

    [SerializeField] private GameObject Chrono1;
    [SerializeField] private GameObject Chrono2;
    [SerializeField] private GameObject Chrono3;
    [SerializeField] private GameObject Chrono4;


    [SerializeField] private GameObject DominG;
    [SerializeField] private GameObject DominD;
    [SerializeField] private GameObject Egal;

    [SerializeField] private GameObject FinG;
    [SerializeField] private GameObject FinD;

    [SerializeField] private GameObject Sifflet;




    private IEnumerator Wait(float WaitTime) {
        Debug.Log("3");

        Chrono1.SetActive(true);
        //1
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("2");
        Chrono1.SetActive(false);
        Chrono2.SetActive(true);
        //2
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("1");
        Chrono2.SetActive(false);
        Chrono3.SetActive(true);
        Bulle_carotte.SetActive(false);
        Bulle_citrouille.SetActive(false);
        //3
        yield return new WaitForSeconds(WaitTime);
        Chrono3.SetActive(false);
        Chrono4.SetActive(true);
        Debug.Log("GOOOOOO");

        Bouton1.SetActive(true);
        Bouton2.SetActive(true);
        Timer.SetActive(true);
        Aide.SetActive(false);
        Anim_Fond.SetActive(false);

        yield return new WaitForSeconds(WaitTime);
        Chrono4.SetActive(false);
        
        //GOOOOOO

    }

    // Start is called before the first frame update
    void Start()
    {
        Chrono1.SetActive(true);
        Chrono2.SetActive(false);
        Chrono3.SetActive(false);
        Chrono4.SetActive(false);
        Bulle_carotte.SetActive(true);
        Bulle_citrouille.SetActive(true);

        Aide.SetActive(true);
        Bouton1.SetActive(false);
        Bouton2.SetActive(false);
        Bouton_Ret1.SetActive(false);
        Bouton_Ret2.SetActive(false);
        Texte1.SetActive(false);
        Texte2.SetActive(false);
        Timer.SetActive(false);
        StartCoroutine(Wait(1F));

        DominG.SetActive(false);
        DominD.SetActive(false);
        Egal.SetActive(false);

        FinD.SetActive(false);
        FinG.SetActive(false);

        Sifflet.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
