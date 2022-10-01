using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framerate : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60;
    }

    
}
