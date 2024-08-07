using UnityEngine;
using UnityEngine.SceneManagement;

public class AnatomyScript : MonoBehaviour
{
    //Panel variable
    public GameObject DentalAnatomy;
    public GameObject AnatomyNotes;
    public GameObject PopupBackground;

    //Model Variable
    public GameObject AnatomyModel;
    public Vector3 OriginalPosition = new Vector3(0f, 0f, 0.374f);
    public Vector3 DownPosition = new Vector3(0f, -0.035f, 0.374f);

    //PopUp panel variables
    public GameObject AnatomyHelp;
    public GameObject UpperCentral;
    public GameObject UpperLateral;
    public GameObject UpperFirstMolar;
    public GameObject UpperSecondMolar;
    public GameObject UpperThirdMolar;
    public GameObject UpperFirstPremolar;
    public GameObject UpperSecondPremolar;
    public GameObject UpperCanine;
    public GameObject LowerCentral;
    public GameObject LowerLateral;
    public GameObject LowerFirstMolar;
    public GameObject LowerSecondMolar;
    public GameObject LowerThirdMolar;
    public GameObject LowerFirstPremolar;
    public GameObject LowerSecondPremolar;
    public GameObject LowerCanine;

    //Zoom variable
    public GameObject ZoomFeature;

    //Icons variable
    public GameObject Help1;
    public GameObject Help2;

    //Method for home button on the anatomy page
    public void AnatomyHomeButton()
    {
        SceneManager.LoadScene("Dashboard");
    }

    //Method for back arrow in the denatl anatomy notes panel
    public void BackArrowButton()
    {
        AnatomyNotes.SetActive(false);
        DentalAnatomy.SetActive(true);
        AnatomyModel.SetActive(true);
    }

    //Method for dental anatomy notes
    public void DentalNotesButton()
    {
        AnatomyNotes.SetActive(true);
        DentalAnatomy.SetActive(false);
        AnatomyModel.SetActive(false);
    }

    //Method for the first help button on the 3d mode to activate the help popup
    public void AnatomyHelp1Button()
    {
        AnatomyHelp.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.SetActive(false);
        ZoomFeature.SetActive(false);
        Help1.SetActive(false);
        Help2.SetActive(true);
    }

    //Method for the second help button on the 3d mode to deactivate the help popup
    public void AnatomyHelp2Button()
    {
        AnatomyHelp.SetActive(false);
        PopupBackground.SetActive(false);
        AnatomyModel.SetActive(true);
        ZoomFeature.SetActive(true);
        Help1.SetActive(true);
        Help2.SetActive(false);
    }

    //method is for the back panel of the 3D mode to deactivate all popups
    public void BackgroundPanel()
    {
        AnatomyModel.SetActive(true);
        AnatomyModel.transform.position = OriginalPosition;
        ZoomFeature.SetActive(true);
        Help1.SetActive(true);
        Help2.SetActive(false);
        AnatomyHelp.SetActive(false);
        PopupBackground.SetActive(false);
        AnatomyHelp.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    //these methods are for all the teeth popups as well as the positioning of the anatomy model
    public void UpperCentralButton()
    {
        UpperCentral.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperLateralButton()
    {
        UpperLateral.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperFirstMolarButton()
    {
        UpperFirstMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperSecondMolarButton()
    {
        UpperSecondMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperThirdMolarButton()
    {
        UpperThirdMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperCanineButton()
    {
        UpperCanine.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperFirstPremolarButton()
    {
        UpperFirstPremolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void UpperSecondPremolarButton()
    {
        UpperSecondPremolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }
    
    public void LowerCentralButton()
    {
        LowerCentral.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerLateralButton()
    {
        LowerLateral.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerFirstMolarButton()
    {
        LowerFirstMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerSecondMolarButton()
    {
        LowerSecondMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerThirdMolarButton()
    {
        LowerThirdMolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
    }

    public void LowerCanineButton()
    {
        LowerCanine.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerFirstPremolarButton()
    {
        LowerFirstPremolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerSecondPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }

    public void LowerSecondPremolarButton()
    {
        LowerSecondPremolar.SetActive(true);
        AnatomyModel.SetActive(true);
        PopupBackground.SetActive(true);
        AnatomyModel.transform.position = DownPosition;
        ZoomFeature.SetActive(false);
        UpperCentral.SetActive(false);
        UpperLateral.SetActive(false);
        UpperCanine.SetActive(false);
        UpperFirstPremolar.SetActive(false);
        UpperSecondPremolar.SetActive(false);
        UpperFirstMolar.SetActive(false);
        UpperSecondMolar.SetActive(false);
        UpperThirdMolar.SetActive(false);
        LowerCentral.SetActive(false);
        LowerLateral.SetActive(false);
        LowerCanine.SetActive(false);
        LowerFirstPremolar.SetActive(false);
        LowerFirstMolar.SetActive(false);
        LowerSecondMolar.SetActive(false);
        LowerThirdMolar.SetActive(false);
    }
}
