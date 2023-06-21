using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] List<GameObject> checkpoints;

    [SerializeField] Vector3 vectorPoint;

    [SerializeField] float dead;

    // Update is called once per frame
    void Update()
    {
        if (player.position.y < dead)
        {
            player.position = vectorPoint;
            HealthController.instance.DealDamage();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        vectorPoint = player.position;
        Destroy(other.gameObject);
    }
}
