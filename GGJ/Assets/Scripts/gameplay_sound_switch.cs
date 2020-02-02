using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay_sound_switch : MonoBehaviour
{

    public AudioSource AS;
    public AudioClip gameplay_loop;
    bool intialized;

    
    void Update()
    {
       // if (intialized)
         //   return;
        /*if (!AS.isPlaying)
        {
            AS.clip = gameplay_loop;
            AS.loop = true;
           // intialized = true;
        }*/
    }
}
