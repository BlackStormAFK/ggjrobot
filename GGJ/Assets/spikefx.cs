using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikefx : MonoBehaviour
{

    public AudioClip fxspike;
    public AudioSource AS;
    public void displaySound()
    {
        AS.PlayOneShot(fxspike);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
