using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPHMovement : MonoBehaviour
{

    public Rigidbody rb;

    [SerializeField] private float movementForce = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Physics for Rigid Body
    void FixedUpdate()
    {
      if(Input.GetKey("o"))
        {
            rb.AddForce(movementForce * Vector3.forward);
        }

        if (Input.GetKey("p"))
        {
            rb.AddForce(movementForce * Vector3.back);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(movementForce * Vector3.right);
            
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(movementForce * Vector3.left);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(movementForce * Vector3.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(movementForce * Vector3.down);
        }


    }
}
