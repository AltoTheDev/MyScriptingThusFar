using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{

    private int rand;
    public int number = 1;

    
    void Start()
    {
        rand = Random.Range(0, 4);
        randCase();
    }

    void randCase()
    {
        switch (rand)
        {
            case 0:
                Debug.Log("state is 1");
                break;

            case 1:
                Debug.Log("state is 2");
                break;

            case 2:
                Debug.Log("state is 3");
                break;
            default:
                Debug.Log("FEILMELDING");
                break;


        }
    }
}
