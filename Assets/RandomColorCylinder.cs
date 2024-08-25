using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorCylinder : MonoBehaviour
{
    public Color color = Color.white;

    // Start is called before the first frame update
    void Start()
    {


        // Pick a random, saturated and not-too-dark color 
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);




    }
}
