using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    private float health;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponentInChildren<Slider>();
        healthSlider.value = 1;
        healthSlider.fillRect.GetComponent<Image>().color = Color.green;
        StartCoroutine(HealthObject());
        
    }

    IEnumerator HealthObject()
    {
        if (RelieveMeasures.reliefOn)
        {
            yield return new WaitForSeconds(30);
            RelieveMeasures.reliefOn = false;
        }
        
        while (healthSlider.value > 0)
        {
            if (healthSlider.value < 0.35f)
            {
                healthSlider.fillRect.GetComponent<Image>().color = Color.red;
            }
            else if(healthSlider.value < 0.65f)
            {
                healthSlider.fillRect.GetComponent<Image>().color = Color.yellow;
            }
            healthSlider.value -= (APICallerScript.AQIndex-0.20f) * 0.1f;
            
            yield return new WaitForSeconds(1);
        }
        Destroy(gameObject);
    }
}
