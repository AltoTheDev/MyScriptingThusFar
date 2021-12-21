using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OverlapSphere : MonoBehaviour
{
    public Collider[] CurrentCubes;
    [SerializeField]
    private Color tintColor = Color.green;
    Collider[] cubesInsideZone;
    Collider[] cubesOutsideZone;

    private void FixedUpdate()
    {
        cubesInsideZone = Physics.OverlapSphere(this.transform.position, 10f);

        foreach(var cube in cubesInsideZone)
        {
            cube.GetComponent<Renderer>().material.color = tintColor; 
        }

        cubesOutsideZone = CurrentCubes.Except(cubesInsideZone).ToArray();

        foreach (var cube in cubesOutsideZone)
        {
            cube.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, 10f);
    }
}
