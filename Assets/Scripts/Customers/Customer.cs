using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public float despawnDelay = 0.9f;

    private bool shouldDespawn;
    private float timer;

    public void SatisfyRequest(Boolean satisfied) {
        if (satisfied.value)
        {
            // wait for delay then destroy myself
            shouldDespawn = true;
        }
        else
        {
            // got a potion, but the wrong potion
        }
        Debug.Log("Customer satisfied? " + satisfied);
    }

    private void Update()
    {
        if (shouldDespawn)
        {
            timer += Time.deltaTime;
            if (timer >= despawnDelay)
            {
                Destroy(gameObject);
            }
        }
    }
}
