using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the camera's swivel and angle rotation based on user input or predefined actions.
/// Allows rotation of the camera horizontally (left/right) and vertically (up/down).
/// </summary>
public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public Transform swivelTransform;
    public Transform angleTransform;

    // Private variables for storing the current swivel (horizontal) and angle (vertical) rotations
    private float xSwivel, ySwivel, zSwivel;
    private float xAngle, yAngle, zAngle;

    void Start()
    {
        InitializeCameras();
    }

    /// <summary>
    /// Initializes the rotation values of the camera based on the current transform values.
    /// Sets the initial rotation angles for both swivel (horizontal) and angle (vertical).
    /// </summary>
    public void InitializeCameras()
    {
        // Initialize the angle (vertical rotation)
        xAngle = angleTransform.eulerAngles.x;
        yAngle = angleTransform.eulerAngles.y;
        zAngle = angleTransform.eulerAngles.z;

        // Initialize the swivel (horizontal rotation)
        xSwivel = swivelTransform.eulerAngles.x;
        ySwivel = swivelTransform.eulerAngles.y;
        zSwivel = swivelTransform.eulerAngles.z;
    }

    /// <summary>
    /// Rotates the camera horizontally to the left by decreasing the Y-axis swivel value.
    /// </summary>
    public void RotateLeft()
    {
        ySwivel -= rotationSpeed * Time.deltaTime;
        swivelTransform.rotation = Quaternion.Euler(xSwivel, ySwivel, zSwivel);
    }

    /// <summary>
    /// Rotates the camera horizontally to the right by increasing the Y-axis swivel value.
    /// </summary>
    public void RotateRight()
    {
        ySwivel += rotationSpeed * Time.deltaTime;
        swivelTransform.rotation = Quaternion.Euler(xSwivel, ySwivel, zSwivel);
    }

    /// <summary>
    /// Rotates the camera vertically upwards by decreasing the X-axis angle value.
    /// Clamps the X-axis rotation to a range between 0 and 35 degrees to prevent over-rotation.
    /// </summary>
    public void RotateUp()
    {
        xAngle -= rotationSpeed * Time.deltaTime;
        xAngle = Mathf.Clamp(xAngle, 0.0f, 35f);
        angleTransform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
    }

    /// <summary>
    /// Rotates the camera vertically downwards by increasing the X-axis angle value.
    /// Clamps the X-axis rotation to a range between 0 and 35 degrees to prevent over-rotation.
    /// </summary>
    public void RotateDown()
    {
        xAngle += rotationSpeed * Time.deltaTime;
        xAngle = Mathf.Clamp(xAngle, 0.0f, 35f);
        angleTransform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
    }

}
