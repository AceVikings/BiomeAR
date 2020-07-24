using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateGroundProps : MonoBehaviour
{
    public GameObject healthSlider;
    public Transform sampleTransform;
    public void StartInstance(GameObject name)
    {
        
        // Vector3 groundpos = new Vector3(0,0,0);
        GameObject newObject = Instantiate(name,transform,false);
        newObject.transform.SetParent(transform);
        newObject.transform.position = sampleTransform.position;
        newObject.AddComponent<MoveObject>();
        newObject.AddComponent<Selected>();
        
        newObject.AddComponent<HealthBarScript>();
        Vector3 pos = sampleTransform.position;
        pos += new Vector3(0,0.6f,0);
        Instantiate(healthSlider, pos, Quaternion.identity, newObject.transform);
        
    }
    
}