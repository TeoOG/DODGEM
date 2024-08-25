using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class move : MonoBehaviour
{


    //public Rigidbody rb;

    public float forwardForce = 5f;
    public float sidewaysForce = 2f;



    void FixedUpdate()
    {



        GetComponent<Rigidbody>().AddForce(0, -forwardForce * Time.deltaTime, 0);






        if (Input.GetKey("d"))
        {

            GetComponent<Rigidbody>().AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {

            GetComponent<Rigidbody>().AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

    }





}
