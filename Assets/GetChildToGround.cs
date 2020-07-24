using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildToGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform[] objects = GetComponentsInChildren<Transform>();
        foreach (var obj in objects)
        {
            obj.position = new Vector3(obj.position.x,0,obj.position.y);
        }
    }
}
