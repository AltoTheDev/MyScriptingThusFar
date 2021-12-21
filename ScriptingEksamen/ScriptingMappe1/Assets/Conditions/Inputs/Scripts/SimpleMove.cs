using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public new GameObject gameObject;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 5.0f, 0);
    }

}
