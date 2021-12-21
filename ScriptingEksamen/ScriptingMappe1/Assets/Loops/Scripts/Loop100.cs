using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop100 : MonoBehaviour
{
    public new GameObject gameObject;
    void Update()
    {
    }

    private void Start()
    {
        Debug.Log("Odd numbers from 1 to 100");
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Even numbers from 1 to 100");
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
