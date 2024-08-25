using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class PrefabSphereMovement : MonoBehaviour
{

    //public float speed = 100f;

    public Rigidbody rb;

    private float moveRandomOn_x;
    private float moveRandomOn_y;
    private float moveRandomOn_z;

    Vector3 startMovement;

    public float startingSpeed = 50f;

    // For bonus 2
    public float speed_change = 1f;
    public float drag_number = 0.1f;

    private void Start()
    {
        moveRandomOn_x = Random.Range(0.1f, 0.9f);
        moveRandomOn_y = Random.Range(0.1f, 0.9f);
        moveRandomOn_z = Random.Range(0.1f, 0.9f);

        startMovement = new Vector3(moveRandomOn_x, moveRandomOn_y, moveRandomOn_z);

        

        rb = GetComponent<Rigidbody>();

        rb.AddForce(startMovement * startingSpeed);

        

    }


    void FixedUpdate()
    {


        if (Input.GetKeyDown(","))
        {

            // Slow down
            rb.drag = drag_number;
            rb.angularDrag = drag_number;

            Debug.Log("drag is : " + rb.drag);

            // Restore speed
            speed_change = 1f;
        }


        if (Input.GetKeyDown("."))
        {
            //rb.AddForce(rb.position * speed_change);

            rb.AddForce(rb.position * speed_change);

            speed_change = speed_change + 0.5f;

            Debug.Log("speed change is : " + speed_change);
        }

    }



}
