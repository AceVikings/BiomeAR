using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAfterSeconds : MonoBehaviour
{
    public float time = 0;
    void OnEnable()
    {
        Invoke("disableGameObject",time);
    }

    void disableGameObject()
    {
        gameObject.SetActive(false);
    }
    
}
