using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Camera cam;
    [SerializeField, Range(1, 100)] private float rotationSpeed = 1;
    [SerializeField] private Ball ballPrefab;
    [SerializeField] private Transform spawnPoint;

    void Awake()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.up = Vector3.MoveTowards(transform.up, mousePosition, rotationSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity).Init(transform.forward);
        }
    }
}
