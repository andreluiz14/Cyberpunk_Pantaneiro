using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PickupCounter pickupCounter = other.GetComponent<PickupCounter>();

        if (pickupCounter != null)
        {
            pickupCounter.PickupCollected();
            gameObject.SetActive(false);
        }
    }
}
