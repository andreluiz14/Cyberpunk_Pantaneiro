using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCounter : MonoBehaviour
{
    public int pickupsCollected { get; private set; }

    public void PickupCollected()
    {
        pickupsCollected++;
    }
}
