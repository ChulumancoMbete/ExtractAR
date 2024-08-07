using UnityEngine;
using UnityEngine.SceneManagement;

public class ARScript : MonoBehaviour
{
    //Variables
    public GameObject InstructionPanel;
    public GameObject ExitBtn;

    //Method for the exit button to go back to the options scene
    public void ExitButton()
    {
        SceneManager.LoadScene("AR Options");
    }

    //method is for the instruction "I understand" button
    public void ContinueButton()
    {
        ExitBtn.SetActive(true);
        InstructionPanel.SetActive(false);
    }
}
