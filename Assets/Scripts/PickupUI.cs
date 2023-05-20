using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupUI : MonoBehaviour
{
    private TextMeshProUGUI pickupText;

    // Start is called before the first frame update
    void Start()
    {
        pickupText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePickupText(PickupCounter pickupCounter)
    {
        pickupText.text = pickupCounter.pickupsCollected.ToString();
    }
}
