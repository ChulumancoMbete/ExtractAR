using UnityEngine;
using UnityEngine.EventSystems;

public class OutlinePart : MonoBehaviour
{
    // Declare variables
    public string selectableTag = "TagMe";
    public Color outlineColor = Color.red;

    private Transform selectedObject;
    //private GameObject currentDuplicate;
    private Outline selectedOutline;
    private Outline outlinedObject;

    void Update()
    {
        // Selection
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag(selectableTag))
            {
                if (selectedOutline != null) // deselect the previously selected object
                {
                    selectedOutline.enabled = false;
                    selectedOutline = null;
                    selectedObject = null;
                }

                selectedObject = hit.transform; // select the new object
                selectedOutline = selectedObject.GetComponent<Outline>();

                if (selectedOutline == null)
                {
                    selectedOutline = selectedObject.gameObject.AddComponent<Outline>();
                    selectedOutline.OutlineMode = Outline.Mode.OutlineAll;
                    selectedOutline.OutlineWidth = 2f;
                }
                selectedOutline.enabled = true;
                selectedOutline.OutlineColor = outlineColor;
            }
            else if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (selectedOutline) // deselect the previously selected tooth 
                {
                    selectedOutline.enabled = false;
                    selectedOutline = null;
                    selectedObject = null;
                }
            }
        }
    }
}
