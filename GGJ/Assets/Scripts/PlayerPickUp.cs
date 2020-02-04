using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUp : MonoBehaviour
{
    public GameObject heart, leftHand, rightHand, body;
    private GameObject Pheart, PleftHand, PrightHand, Pbody;
    public int oHeart;
    public int oLH;
    public int oRH;
    public int oBody;
    public int partsCollected = 0;

    public int GetPartsCollected()
    {
        return partsCollected;
    }
    public GameObject GetHeart()
    {
        return heart;
    }
    public GameObject GetLeftHand()
    {
        return leftHand;
    }
    public GameObject GetRightHand()
    {
        return rightHand;
    }
    public GameObject GetBody()
    {
        return body;
    }
    public GameObject GetPHeart()
    {
        return Pheart;
    }
    public GameObject GetPLeftHand()
    {
        return PleftHand;
    }
    public GameObject GetPRightHand()
    {
        return PrightHand;
    }
    public GameObject GetPBody()
    {
        return Pbody;
    }
    public void SetPartsCollected(int value)
    {
        partsCollected=value;
    }

    public int GetOHeart()
    {
        return oHeart;
    }

    public void SetOHeart(int value)
    {
        oHeart = value;
    }

    public int GetOLH()
    {
        return oLH;
    }

    public void SetOLH(int value)
    {
        oLH = value;
    }

    public int GetORH()
    {
        return oRH;
    }

    public void SetORH(int value)
    {
        oRH = value;
    }

    public int GetObody()
    {
        return oBody;
    }

    public void SetObody(int value)
    {
        oBody=value;
    }


    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        if(heart.activeInHierarchy && leftHand.activeInHierarchy && rightHand.activeInHierarchy && body.activeInHierarchy)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter(Collider other)
    { 
        //if (other.gameObject.CompareTag("Collectables"))
      //  {
           // SetPartsCollected(GetPartsCollected()+1);
            string ObjectName = other.gameObject.name;
            switch (ObjectName)
            {
                case "leftHand":
                SetPartsCollected(GetPartsCollected() + 1);
                other.gameObject.SetActive(false);
                    leftHand.SetActive(true);
                    SetOLH(GetPartsCollected());
                    PleftHand = other.gameObject;
                    break;

                case "rightHand":
                SetPartsCollected(GetPartsCollected() + 1);
                other.gameObject.SetActive(false);
                    rightHand.SetActive(true);
                    SetORH(GetPartsCollected());
                    PrightHand = other.gameObject;
                break;

                case "body":
                SetPartsCollected(GetPartsCollected() + 1);
                other.gameObject.SetActive(false);
                    body.SetActive(true);
                    SetObody(GetPartsCollected());
                    Pbody = other.gameObject;
                break;

                case "heart":
                if (leftHand.activeInHierarchy && rightHand.activeInHierarchy && body.activeInHierarchy)
                {
                    SetPartsCollected(GetPartsCollected() + 1);
                    other.gameObject.SetActive(false);
                    heart.SetActive(true);
                    SetOHeart(GetPartsCollected());
                    Pheart = other.gameObject;
                }
                break;

                default:
                    break;
            }
        //}
    }
}
