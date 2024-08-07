using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DashboardScript : MonoBehaviour
{
    //Method for "Dental Anatomy" button
    public void DentalAnatomyButton()
    {
        SceneManager.LoadScene("3D Mode");
    }

    //Method that will take you to the AR options before going to the AR Mode
    public void AROptions()
    {
        SceneManager.LoadScene("AR Options");
    }

    //Option scene buttons scripts
    //this method is used to navigate to the ar lower canine scene
    public void ARCanine()
    {
        SceneManager.LoadScene("AR Lower Canine");
    }

    //this method is used to navigate to the ar lower central scene
    public void ARCentral()
    {
        SceneManager.LoadScene("AR Lower Central");
    }

    //this method is used to navigate to the ar lower premolar scene
    public void ARPremolar()
    {
        SceneManager.LoadScene("AR Lower Premolar");
    }

    //this method is used to navigate to the ar notes (extraction notes) scene
    public void ARNotes()
    {
        SceneManager.LoadScene("AR Notes");
    }

    //this method is used to navigate to the back to the dashboard scene
    public void Home()
    {
        SceneManager.LoadScene("Dashboard");
    }

    //Dashboard option of the quiz button
    public void Quiz()
    {
        SceneManager.LoadScene("Quiz");
    }
}
