using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    public GameObject heart, leftHand, rightHand, body;
    
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    void OnTriggerEnter(Collider other)
    {
        string ObjectName = other.gameObject.name;
        switch (ObjectName)
        {
            case "leftHand":
                other.gameObject.SetActive(false);
                leftHand.SetActive(true);
                break;

            case "rightHand":
                other.gameObject.SetActive(false);
                rightHand.SetActive(true);
                break;

            case "body":
                other.gameObject.SetActive(false);
                body.SetActive(true);
                break;

            case "heart":
                other.gameObject.SetActive(false);
                heart.SetActive(true);
                break;

            default:
                break;
        }
    }
}
