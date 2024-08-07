using UnityEngine;
using UnityEngine.UI;

public class Zoom : MonoBehaviour
{
    public float minScale = 0.7f;
    public float maxScale = 1.2f;
    public Button zoomInButton;
    public Button zoomOutButton;
    public Slider zoomSlider;

    private Vector3 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;

        zoomInButton.onClick.AddListener(ZoomIn);
        zoomOutButton.onClick.AddListener(ZoomOut);

        zoomSlider.onValueChanged.AddListener(ZoomObject);
    }

    private void ZoomIn()
    {
        float currentZoom = zoomSlider.value;
        float newZoom = Mathf.Clamp(currentZoom + 0.1f, 0f, 1f);
        zoomSlider.value = newZoom;

        UpdateScale();
    }

    private void ZoomOut()
    {
        float currentZoom = zoomSlider.value;
        float newZoom = Mathf.Clamp(currentZoom - 0.1f, 0f, 1f);
        zoomSlider.value = newZoom;

        UpdateScale();
    }

    private void ZoomObject(float value)
    {
        UpdateScale();
    }

    private void UpdateScale()
    {
        float zoomLevel = zoomSlider.value;
        Vector3 newScale = initialScale * Mathf.Lerp(minScale, maxScale, zoomLevel);
        transform.localScale = newScale;
    }
}
