using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {

        // Check if ESC is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
            // Quit
            Application.Quit();
    }
}
