/**************************************************************************
* Copyright (C) echoAR, Inc. 2018-2020.                                   *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echoar.xyz/terms, or another agreement                      *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    private GameObject sphere;
    private string URL;
    /// <summary>
    /// EXAMPLE BEHAVIOUR
    /// Queries the database and names the object based on the result.
    /// </summary>

    // Use this for initialization
    void Start()
    {
        sphere = StaticPrefabHolder.Sphere;
        // Add RemoteTransformations script to object and set its entry
        gameObject.AddComponent<RemoteTransformations>().entry = entry;
        
        // Qurey additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            gameObject.name = value;
        }
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("URL", out value))
        {
            URL = value;
        }
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("type", out value))
        {
            if (value != "video")
            {
                gameObject.AddComponent<Floating>();
            }
            else
            {
                gameObject.AddComponent<ExpFaceCamera>();
            }
        }
        

    }

    // void GoToURL()
    // {
    //     Application.OpenURL(URL);
    // }

    // Update is called once per frame
    void Update()
    {
        // var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit Hit;
        //  
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("Click");
        //     Debug.Log(Physics.Raycast(ray, out Hit));
        //     Debug.Log(Hit.collider.gameObject.name);
        //     Debug.Log(gameObject.name);
        //     if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
        //     {
        //         Debug.Log("HIT");
        //         GoToURL();
        //     }
        // }   
    }
    
    
}