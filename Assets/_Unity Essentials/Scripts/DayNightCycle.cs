using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The number of seconds it takes for one full day to pass
    [Tooltip("Number of seconds for a full day cycle (from 0 to 24 hours)")]
    public float dayLengthInSeconds = 60f;

    // Cached reference to the light component
    private Light directionalLight;

    // The starting rotation of the light
    private float startingRotation;

    void Start()
    {
        // Get the Directional Light component attached to the GameObject
        directionalLight = GetComponent<Light>();
        
        // Optionally store the initial rotation if you want to maintain it at the start of the scene
        startingRotation = transform.rotation.eulerAngles.x;
    }

    void Update()
    {
        // Calculate the amount of rotation needed per second
        float rotationPerSecond = 360f / dayLengthInSeconds;

        // Update the light's rotation based on time
        float newRotation = startingRotation + Time.time * rotationPerSecond;

        // Set the rotation of the light to simulate the day passing (rotate around the X-axis)
        transform.rotation = Quaternion.Euler(newRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}