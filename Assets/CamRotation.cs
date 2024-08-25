using UnityEngine;
using System.Collections;

public class CamRotation : MonoBehaviour
{
    public float speedH = 1.0f;
    public float speedV = 1.0f;

    private float x = 0.0f;
    private float y = 0.0f;

    void Update()
    {
        x += speedH * Input.GetAxis("Mouse X");
        y -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(y, x, 0.0f);

        
    }
}


