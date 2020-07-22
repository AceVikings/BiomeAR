using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class MoveObject : MonoBehaviour
{
    private Touch touch;
    private float speedModifier = 0.01f;
    

    private void Update()
    {
        
        if (Input.touchCount > 0)
        {   
            
            
            touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Moved && transform.GetComponent<Selected>().isSelected)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x*speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y*speedModifier);
                
                
            }
        }
    }
}
