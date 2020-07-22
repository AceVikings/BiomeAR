using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketPlaceController : MonoBehaviour
{
    [SerializeField] private Text coins;
    [SerializeField] private Text purchase;

    public GameObject collectible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyCollectible(GameObject name)
    {
        new NotImplementedException();
    }
    public void buyRelief()
    {
        RelieveMeasures.reliefOn = true;
    }
    
    
}
