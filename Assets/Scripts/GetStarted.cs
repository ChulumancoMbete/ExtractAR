using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetStarted : MonoBehaviour
{
    //Method for "Get Started" button 
    public void GetStartedButton()
    {
        SceneManager.LoadScene("Dashboard");
    }
}
