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

    private IEnumerator Wait(float WaitTime) {
        Debug.Log("3");
        //1
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("2");
        //2
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("1");
        //3
        yield return new WaitForSeconds(WaitTime);
        Debug.Log("GOOOOOO");
        Bouton1.SetActive(true);
        Bouton2.SetActive(true);
        Timer.SetActive(true);
        //GOOOOOO
    }

    // Start is called before the first frame update
    void Start()
    {
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
