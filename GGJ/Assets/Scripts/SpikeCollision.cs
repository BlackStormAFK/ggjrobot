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
        Debug.Log("Destroyed object position : " + value);
        if (value >= 1)
        {
            destroyedItem = Mathf.Abs(Random.Range(1, value + 1));
            if (pickUp.GetObody() == destroyedItem)
            {
                pickUp.SetObody(0);
                pickUp.GetPBody().SetActive(true);
                pickUp.GetBody().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected() - 1);
                if (pickUp.GetOHeart() > destroyedItem)
                {
                    pickUp.SetOHeart(pickUp.GetOHeart() - 1);
                }
                if (pickUp.GetOLH() > destroyedItem)
                {
                    pickUp.SetOLH(pickUp.GetOLH() - 1);
                }
                if (pickUp.GetORH() > destroyedItem)
                {
                    pickUp.SetORH(pickUp.GetORH() - 1);
                }

            }
            if (pickUp.GetOLH() == destroyedItem)
            {
                pickUp.SetOLH(0);
                pickUp.GetPLeftHand().SetActive(true);
                pickUp.GetLeftHand().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected() - 1);
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
                    pickUp.SetObody(pickUp.GetObody() - 1);
                }
            }
            if (pickUp.GetORH() == destroyedItem)
            {
                pickUp.SetORH(0);
                pickUp.GetPRightHand().SetActive(true);
                pickUp.GetRightHand().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected() - 1);
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
                pickUp.SetOHeart(0);
                pickUp.GetPHeart().SetActive(true);
                pickUp.GetHeart().SetActive(false);
                pickUp.SetPartsCollected(pickUp.GetPartsCollected() - 1);
                if (pickUp.GetOLH() > destroyedItem)
                {
                    pickUp.SetOLH(pickUp.GetOLH() - 1);
                }
                if (pickUp.GetORH() > destroyedItem)
                {
                    pickUp.SetORH(pickUp.GetORH() - 1);
                }
                if (pickUp.GetObody() > destroyedItem)
                {
                    pickUp.SetObody(pickUp.GetObody() - 1);
                }
            }/*else
        {
            destroyedItem = 1;
        }*/

        }


    }

}
