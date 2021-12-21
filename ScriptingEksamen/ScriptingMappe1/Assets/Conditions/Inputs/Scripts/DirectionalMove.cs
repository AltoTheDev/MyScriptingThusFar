using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMove : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection;

        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(0, 5.0f, 0);
        
    }

}
