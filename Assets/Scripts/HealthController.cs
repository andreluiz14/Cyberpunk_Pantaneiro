using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static HealthController instance;

    private void Awake()
    {
        instance = this;
    }

    public int currentHealth, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DealDamage()
    {
        currentHealth--;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
