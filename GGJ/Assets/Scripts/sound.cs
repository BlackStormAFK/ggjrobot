using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource menuAS;
    public AudioSource gameplayAS;
    public AudioSource SFXAS;
    public AudioSource walking;

    public AudioClip click;
    public AudioClip hit;
//    public AudioClip step;
    public AudioClip win;
    public AudioClip ay;
    public AudioClip fall;
    public AudioClip gameplayloop;





    public void menu_sound()
    {
        Instantiate(menuAS);
    }

    public void gameplay_sound()
    {
        Instantiate(gameplayAS);
    }

    public void walking_sound()
    {
        Instantiate(walking);
    }

    public void click_sound()
    {
        SFXAS.PlayOneShot(click);
    }
    public void fall_sound()
    {
        SFXAS.PlayOneShot(fall);
    }
    public void hit_sound()
    {
        SFXAS.PlayOneShot(hit);
        Invoke("ay_sound", 0.3f);
    }

    public void ay_sound()
    {
        SFXAS.PlayOneShot(ay);
    }

     public void win_sound()
     {
        SFXAS.PlayOneShot(win);
    }
}