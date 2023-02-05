using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decompte : MonoBehaviour
{

    [SerializeField] private GameObject Bouton1;
    [SerializeField] private GameObject Bouton2;
    [SerializeField] private GameObject Bouton_Ret;
    [SerializeField] private GameObject Timer;
    [SerializeField] private GameObject Texte1;
    [SerializeField] private GameObject Texte2;
    [SerializeField] private GameObject Bulle_carotte;
    [SerializeField] private GameObject Bulle_citrouille;



    [SerializeField] private GameObject Chrono1;
    [SerializeField] private GameObject Chrono2;
    [SerializeField] private GameObject Chrono3;
    [SerializeField] private GameObject Chrono4;
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

        Bouton1.SetActive(false);
        Bouton2.SetActive(false);
        Bouton_Ret.SetActive(false);
        Texte1.SetActive(false);
        Texte2.SetActive(false);
        Timer.SetActive(false);
        StartCoroutine(Wait(1F));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
