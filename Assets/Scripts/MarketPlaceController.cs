using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketPlaceController : MonoBehaviour
{
    [SerializeField] private Text coins;
    [SerializeField] private Text goodiecoin;
    private int coint = 500;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyGoodie()
    {
        coint -= 50;
        coins.text = coint.ToString();
        goodiecoin.text = coint.ToString();
    }
    public void buyRelief()
    {
        coint -= 100;
        coins.text = coint.ToString();
        goodiecoin.text = coint.ToString();
        RelieveMeasures.reliefOn = true;
    }
    
    
}
