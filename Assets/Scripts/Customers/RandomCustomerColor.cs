using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class RandomCustomerColor : MonoBehaviour
{
  [SerializeField] float hueMin = 0f;
  [SerializeField] float hueMax = 1f;
  [SerializeField] float saturationMin = 0f;
  [SerializeField] float saturationMax = 1f;
  [SerializeField] float valueMin = 0f;
  [SerializeField] float valueMax = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
