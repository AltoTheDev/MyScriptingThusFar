using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    int current = 0;
    int prev = 0;



    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= 10; i++)
        {
            Debug.Log(current);
            if (current == 0)
            {
                current = 1;
            }
            else
            {
                int temp = current;
                current = current + prev;
                prev = temp;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
