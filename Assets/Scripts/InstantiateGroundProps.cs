using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGroundProps : MonoBehaviour
{
    public GameObject healthSlider;
    
    public void StartInstance(GameObject name)
    {
        
        Vector3 groundpos = new Vector3(0,0.9f,0);
        GameObject newObject = Instantiate(name, groundpos, Quaternion.identity, transform);
        newObject.AddComponent<MoveObject>();
        newObject.AddComponent<Selected>();
        newObject.AddComponent<HealthBarScript>();
        Vector3 pos = new Vector3(0,5.5f,0);
        Instantiate(healthSlider, pos, Quaternion.identity, newObject.transform);
    }
    
}