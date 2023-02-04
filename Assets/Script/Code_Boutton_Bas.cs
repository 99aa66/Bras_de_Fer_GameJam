using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code_Boutton_Bas : MonoBehaviour
{
    private int Score2 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Score2 += 1;
        }
        if (Score2 > 3)
        {
            Debug.Log("Perdu");
        }
    }
}
