using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int targetFrameRate = 50;


    void Awake()
    {
        // Set frames per second
        Application.targetFrameRate = targetFrameRate;


        // Sync framerate to monitors refresh rate - 0 disable
        QualitySettings.vSyncCount = 0;
        

    }


}
