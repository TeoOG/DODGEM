using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VSyncCount : MonoBehaviour
{

    public int targetFrameRate = 50;

    
    void Awake()
    {
        // Sync framerate to monitors refresh rate - 0 disable
        QualitySettings.vSyncCount = 0;
        // Set frames per second
        Application.targetFrameRate = targetFrameRate;

    }

    
}
