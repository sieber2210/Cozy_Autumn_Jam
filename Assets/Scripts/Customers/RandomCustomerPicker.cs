using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCustomerPicker : MonoBehaviour
{
    private static Vector3 CUSTOMER_SCALE = new Vector3(4f, 4f, 4f);

    public GameObject[] CustomerArray;
    public GameObject thoughtBubble;

    public float spawnDelay = 1.5f;
    private bool shouldSpawn;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCustomer();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn) {
            timer += Time.deltaTime;
            if (timer >= spawnDelay) {
                SpawnCustomer();
                thoughtBubble.SetActive(true);
                timer = 0f;
                shouldSpawn = false;
            }
        }
    }

    public void ShouldSpawn(Boolean shouldSpawn) {
        this.shouldSpawn = shouldSpawn.value;
    }

    private void SpawnCustomer() {
        GameObject customer = null;
        int RandNum = Random.Range(0, CustomerArray.Length);
        if (RandNum == 0)
        {
            customer = Instantiate(CustomerArray[0], transform.position, transform.rotation);
        }
        else if (RandNum == 1)
        {
            customer = Instantiate(CustomerArray[1], transform.position, transform.rotation);
        }
        else if (RandNum == 2)
        {
            customer = Instantiate(CustomerArray[2], transform.position, transform.rotation);
        }
        else if (RandNum == 3)
        {
            customer = Instantiate(CustomerArray[3], transform.position, transform.rotation);
        }
        customer.transform.localScale = CUSTOMER_SCALE;
    }
}
