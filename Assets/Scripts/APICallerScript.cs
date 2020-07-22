using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class APICallerScript : MonoBehaviour
{
    //This script uses ipStack and weatherbit api
    //API Keys
    [SerializeField] private string ipStackKey;
    [SerializeField] private string weatherBitKey;

    //location variables
    private string lat;
    private string lng;

    public Slider aqiSlider;
    public static float AQIndex;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetLocation());
    }
    
    //Coroutine to Get user location
    IEnumerator GetLocation()
    {
        string URL = "http://api.ipstack.com/check?access_key=" + ipStackKey+"&fields=main";
        UnityWebRequest request = UnityWebRequest.Get(URL);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            Debug.LogError(request.error);
            yield break;
            
        } 
        JSONNode info = JSON.Parse(request.downloadHandler.text);
        lat = info["latitude"];
        lng = info["longitude"];
        StartCoroutine(GetAirQuality());
    }

    //Coroutine to get user Air Quality
    IEnumerator GetAirQuality()
    {
        string URL = "https://api.weatherbit.io/v2.0/current/airquality?lat=" + lat + "&lon=" + lng + "&key=" +
                     weatherBitKey;
        UnityWebRequest request = UnityWebRequest.Get(URL);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            Debug.LogError(request.error);
            yield break;
            
        } 
        JSONNode info = JSON.Parse(request.downloadHandler.text);
        Debug.Log(info["data"][0]["aqi"]);

        aqiSlider.value = info["data"][0]["aqi"].AsFloat/500f;
        AQIndex = aqiSlider.value;
        if (aqiSlider.value < (float)50/500)
        {
            aqiSlider.fillRect.GetComponent<Image>().color = Color.green;
        }
        else if (aqiSlider.value < (float)100/500)
        {
            aqiSlider.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else if (aqiSlider.value < (float)150/500)
        {
            aqiSlider.fillRect.GetComponent<Image>().color = new Color(1,0.5f,0.4f,1);
        }
        else if (aqiSlider.value < (float)200/500)
        {
            aqiSlider.fillRect.GetComponent<Image>().color = Color.red;
        }
        else if (aqiSlider.value < (float)300/500)
        {
            aqiSlider.fillRect.GetComponent<Image>().color = Color.magenta;
        }
        else 
        {
            aqiSlider.fillRect.GetComponent<Image>().color = new Color(0.5f,0f,0f,1);
        }
        
    
    }

    private void Update()
    {
        text.text = Input.touchCount.ToString();
    }
}
