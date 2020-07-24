using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoRedirect : MonoBehaviour
{
    public void Redirect()
    {
        Application.OpenURL("https://www.epa.gov/");
    }
}
