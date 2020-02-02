﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    public PlayerMovement pM;
    public PlayerPickUp pickUp;
    public int destroyedItem;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Vector3 startingPosition = pM.startingPosition;
            transform.position = startingPosition;
            DestroyParts(pickUp.GetPartsCollected());

        }

    }
    private void DestroyParts(int value) 
    {
        if (value > 1)
        {
            destroyedItem = Mathf.Abs(Random.Range(1, value + 1));
        }else
        {
            destroyedItem = 1;
        }
            if (pickUp.GetObody() == destroyedItem)
            {
                pickUp.GetPBody().SetActive(true);
                pickUp.GetBody().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected()-1);
                if(pickUp.GetOHeart() > destroyedItem)
                {
                    pickUp.SetOHeart(pickUp.GetOHeart()-1);
                }
                if (pickUp.GetOLH() > destroyedItem)
                {
                    pickUp.SetOLH(pickUp.GetOLH()-1);
                }
                if (pickUp.GetORH() > destroyedItem)
                {
                    pickUp.SetORH(pickUp.GetORH() - 1);
                }

            }
            if (pickUp.GetOLH() == destroyedItem)
            {
                pickUp.GetPLeftHand().SetActive(true);
                pickUp.GetLeftHand().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected()-1);
                if (pickUp.GetOHeart() > destroyedItem)
                {
                    pickUp.SetOHeart(pickUp.GetOHeart() - 1);
                }
                if (pickUp.GetORH() > destroyedItem)
                {
                    pickUp.SetORH(pickUp.GetORH() - 1);
                }
                if (pickUp.GetObody() > destroyedItem)
                {
                    pickUp.SetObody(pickUp.GetObody()-1);
                }
        }
            if (pickUp.GetORH() == destroyedItem)
            {
                pickUp.GetPRightHand().SetActive(true);
                pickUp.GetRightHand().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected()-1);
                if (pickUp.GetOHeart() > destroyedItem)
                {
                    pickUp.SetOHeart(pickUp.GetOHeart() - 1);
                }
                if (pickUp.GetOLH() > destroyedItem)
                {
                    pickUp.SetOLH(pickUp.GetOLH() - 1);
                }
                if (pickUp.GetObody() > destroyedItem)
                {
                    pickUp.SetObody(pickUp.GetObody() - 1);
                }
        }
            if (pickUp.GetOHeart() == destroyedItem)
            {
                pickUp.GetPHeart().SetActive(true);
                pickUp.GetHeart().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected()-1);
                if (pickUp.GetOLH() > destroyedItem)
                {
                    pickUp.SetOLH(pickUp.GetOLH() - 1);
                }
                if (pickUp.GetORH() > destroyedItem)
                {
                    pickUp.SetORH(pickUp.GetORH()-1);
                }
                if (pickUp.GetObody() > destroyedItem)
                {
                    pickUp.SetObody(pickUp.GetObody() - 1);
                }
        }
            
             
    }

}
