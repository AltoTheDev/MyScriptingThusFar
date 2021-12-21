using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrintFromRandom : MonoBehaviour
{
    int rand;
     void Update()
    {
        int smallNumber;
        smallNumber = Random.Range(0, 20);
        
        if (rand <= 20)
        {
            Debug.Log("20 a small number");
        }
        else if (rand > 20 && rand <= 80)
        {
            Debug.Log("80 is a medium number");
        }
        else
        {
            Debug.Log("100 is a big number");
        }

        int mediumNumber;
        mediumNumber = Random.Range(21, 80);

        if (rand <= 80)
        {
            Debug.Log("20 a small number");
        }
        else if (rand > 20 && rand <= 80)
        {
            Debug.Log("80 is a medium number");
        }
        else
        {
            Debug.Log("100 is a big number");
        }

        int bigNumber;
        bigNumber = Random.Range(81, 100);

        if (rand <= 80)
        {
            Debug.Log("20 a small number");
        }
        else if (rand > 20 && rand <= 80)
        {
            Debug.Log("80 is a medium number");
        }
        else
        {
            Debug.Log("100 is a big number");
        }
    }
}
