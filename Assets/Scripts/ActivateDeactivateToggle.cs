using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateToggle : MonoBehaviour
{
    public void Toggle()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
