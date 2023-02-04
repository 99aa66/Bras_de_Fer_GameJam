using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decompte : MonoBehaviour
{

    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
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
        Button1.SetActive(true);
        Button2.SetActive(true);
        //GOOOOOO
    }

    // Start is called before the first frame update
    void Start()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Texte1.SetActive(false);
        Texte2.SetActive(false);
        StartCoroutine(Wait(1F));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
