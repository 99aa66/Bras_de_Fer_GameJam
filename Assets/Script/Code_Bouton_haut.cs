using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Code_Bouton_haut : MonoBehaviour
{
    public int Score1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Score1 += 1;
            Debug.Log("BEH");
        }
        
    }
}
