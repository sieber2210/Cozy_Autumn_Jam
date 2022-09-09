using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject foo;

    private void Awake()
    {
        Debug.Log("Gotteem!!");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            foo.transform.Translate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            foo.transform.Translate(Vector3.back);
        }
    }
}
