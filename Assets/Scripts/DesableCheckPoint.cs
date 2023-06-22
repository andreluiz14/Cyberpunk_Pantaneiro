using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesableCheckPoint : MonoBehaviour
{
    [SerializeField] private BoxCollider _triggerCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        _triggerCheckPoint = GetComponent<BoxCollider>();
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Jogador"))
            _triggerCheckPoint.enabled = false;
    }
}
