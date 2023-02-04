using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton_Droite_Code : MonoBehaviour
{
    private int Score2 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void ClickDroite()
    {
        
        Score2 += 1;
        Debug.Log("BEH");

        if (Score2 > 3)
        {
            Debug.Log("Perdu");
        }
    }
}

