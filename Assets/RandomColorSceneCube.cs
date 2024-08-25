using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorSceneCube : MonoBehaviour
{
    public Color color = Color.white;

    // Start is called before the first frame update
    void Start()
    {


        // Pick a random, saturated and not-too-dark color , last two arguments change aplha for transparency 
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f, 0.4f, 0.4f);




    }
}
