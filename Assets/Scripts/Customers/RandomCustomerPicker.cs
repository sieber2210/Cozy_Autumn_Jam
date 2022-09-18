using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCustomerPicker : MonoBehaviour
{
    public GameObject[] CustomerArray;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int RandNum = Random.Range(0, CustomerArray.Length);
            if (RandNum == 0)
            {
                Instantiate(CustomerArray[0], transform.position, transform.rotation);
            }
            else if (RandNum == 1)
            {
                Instantiate(CustomerArray[1], transform.position, transform.rotation);
            }
            else if (RandNum == 2)
            {
                Instantiate(CustomerArray[2], transform.position, transform.rotation);
            }
            else if (RandNum == 3)
            {
                Instantiate(CustomerArray[3], transform.position, transform.rotation);
            }
        }
    }
}
