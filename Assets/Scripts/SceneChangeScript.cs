using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void GoToMart()
    {
        SceneManager.LoadScene("MartScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("GameScene");
    }
}
