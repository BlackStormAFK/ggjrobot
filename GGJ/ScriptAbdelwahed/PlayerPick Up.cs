using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{/*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     */
    void OnTriggerEnter(Collider other)
    {
        string ObjectName = other.gameObject.tag;
        switch (ObjectName)
        {
            case "leftHand":
                other.gameObject.SetActive(false);
                break;

            case "rightHand":
                other.gameObject.SetActive(false);
                break;

            case "body":
                other.gameObject.SetActive(false);
                break;

            case "heart":
                other.gameObject.SetActive(false);
                break;

            default:
                break;
        }
    }
}

            
    
