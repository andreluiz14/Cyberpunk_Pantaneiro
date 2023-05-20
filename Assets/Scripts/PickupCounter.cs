using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupCounter : MonoBehaviour
{
    public int pickupsCollected { get; private set; }

    public UnityEvent<PickupCounter> OnPickupCollected;

    public void PickupCollected()
    {
        pickupsCollected++;
        OnPickupCollected.Invoke(this);
    }
}
