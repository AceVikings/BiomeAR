using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public float horiSpeed;
    public float vertiSpeed;
    public float amplitude;

    public Vector3 tempPoisition;

    private void Start()
    {
        
        vertiSpeed = 0.3f;
        amplitude = 0.5f;
        tempPoisition = transform.position;
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.realtimeSinceStartup*vertiSpeed)*amplitude-1,transform.position.z);
        // tempPoisition.y =Mathf.Sin(Time.realtimeSinceStartup*vertiSpeed)*amplitude-1;
        // transform.position = tempPoisition;
    }
}
