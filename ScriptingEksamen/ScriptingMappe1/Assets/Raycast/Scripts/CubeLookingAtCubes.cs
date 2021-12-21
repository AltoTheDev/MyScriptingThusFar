using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLookingAtCubes : MonoBehaviour
{
    [SerializeField]
    private Color tintColor = Color.green;
    [SerializeField]
    private Color tintColorForRaycastAll = Color.yellow;
    [SerializeField]
    private bool multiple;

    private void Update()
    {
        if (multiple)
            RaycastMultiple();
        else
            RaycastSingle();
    }

    private void RaycastSingle()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        float maxDistance = 5f;

        Debug.DrawRay(origin, direction * maxDistance, Color.red);
        Ray ray = new Ray(origin, direction);

        

        bool result = Physics.Raycast(ray, out RaycastHit raycastHit, maxDistance);

        if (result)
        {
            raycastHit.collider.GetComponent<Renderer>().material.color = tintColor;
        }
    }

    private void RaycastMultiple()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        Debug.DrawRay(origin, direction * 10f, Color.yellow);
        Ray ray = new Ray(origin, direction);

        var multipleHits = Physics.RaycastAll(ray);
        foreach (var raycastHit in multipleHits)
        {
            raycastHit.collider.GetComponent<Renderer>().material.color = tintColor;
        }
    }

}
