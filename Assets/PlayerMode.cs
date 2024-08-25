using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMode : MonoBehaviour
{
    public Rigidbody rb;

    bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            on = !on;

        if(on)
        {
            // Not Kinematic
            rb.isKinematic = false;
            rb.detectCollisions = true;

            // Enable Gravity
            rb.useGravity = true;
        }

        if (!on)
        {

            // Not Kinematic
            rb.isKinematic = true;
            rb.detectCollisions = false;

            // Enable Gravity
            rb.useGravity = false;


        }

    }
}
