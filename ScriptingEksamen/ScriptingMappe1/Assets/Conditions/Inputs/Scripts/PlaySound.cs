using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);
            Debug.Log("Sound is played");
        }
    }
}
