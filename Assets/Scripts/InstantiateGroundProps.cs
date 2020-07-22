using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGroundProps : MonoBehaviour
{
    public void StartInstance(GameObject name)
    {
        GameObject newObject = Instantiate(name, Vector3.zero, Quaternion.identity, transform);
        newObject.AddComponent<MoveObject>();
        newObject.AddComponent<Selected>();
    }
    
}