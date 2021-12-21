using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    public void Init(Vector2 dir)
    {
        rb.velocity = dir * speed;
    }

    
}
