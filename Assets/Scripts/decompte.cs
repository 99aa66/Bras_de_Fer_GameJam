using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decompte : MonoBehaviour
{

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
        //GOOOOOO
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait(1F));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
