/*-----------------------------------------------------------------------------
    PressButton.cs

    This script controls the behavior of a button in Unity. When an object
    collides with the button, it presses down, changes color and triggers the camera movement.
    The button continues to invoke the assigned function while it is pressed down.
    Author: Juan Núñez
    Creation: 10-08-2024
    Modification:09-10-2024

-----------------------------------------------------------------------------*/

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PressButton : MonoBehaviour
{
    // Public Variables
    public Transform cylinder;
    public float pressDepth;
    public float pressSpeed;
    public Color pressedColor;
    public float callInterval = 0.2f; // How frequently to call the press action.

    public UnityEvent OnButtonPress;
    public UnityEvent OnButtonRelease;

    // Public read-only property to check if the button is currently pressed.
    public bool IsPressed { get; private set; } = false;

    // Private Variables
    private Color originalColor;
    private Vector3 initialPosition;
    private Renderer cylinderRenderer;
    private Coroutine pressCoroutine;  // Reference to the coroutine that handles repeated calls.

    /// <summary>
    /// Initializes the button by storing the initial position and color of the cylinder.
    /// Logs an error if the cylinder reference is not assigned.
    /// </summary>
    void Start()
    {
        if (cylinder == null)
        {
            Debug.LogError("Cylinder not assigned!");
            return;
        }
        initialPosition = cylinder.position;
        cylinderRenderer = cylinder.GetComponent<Renderer>();
        originalColor = cylinderRenderer.material.color;
    }

    /// <summary>
    /// Called when another collider enters the trigger collider attached to this object.
    /// Starts the button press process if the button is not already pressed.
    /// </summary>
    /// <param name="other">The other collider that enters the trigger.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (!IsPressed)
        {
            IsPressed = true;
            pressCoroutine = StartCoroutine(PressingButton());
        }
    }

    /// <summary>
    /// Coroutine to handle continuous invocation of the button press action while pressed.
    /// </summary>
    /// <returns>An IEnumerator for the coroutine.</returns>
    private IEnumerator PressingButton()
    {
        Vector3 targetPosition = initialPosition - new Vector3(0, pressDepth, 0);
        cylinderRenderer.material.color = pressedColor;

        // Continue pressing the button and calling the function.
        while (IsPressed)
        {
            cylinder.position = Vector3.MoveTowards(cylinder.position, targetPosition, pressSpeed * Time.deltaTime);

            // Call the assigned function while pressed.
            OnButtonPress?.Invoke();

            // Wait for the interval before calling again.
            yield return new WaitForSeconds(callInterval);
        }
    }

    /// <summary>
    /// Called when another collider exits the trigger collider attached to this object.
    /// Starts the button release process if the button is currently pressed.
    /// </summary>
    /// <param name="other">The other collider that exits the trigger.</param>
    private void OnTriggerExit(Collider other)
    {
        if (IsPressed)
        {
            StopCoroutine(pressCoroutine);  // Stop the coroutine when the button is released.
            StartCoroutine(ReleaseButton());
        }
    }

    /// <summary>
    /// Coroutine to animate the button release action.
    /// Moves the cylinder back to its initial position to simulate releasing the button.
    /// </summary>
    /// <returns>An IEnumerator for the coroutine.</returns>
    private IEnumerator ReleaseButton()
    {
        while (cylinder.position != initialPosition)
        {
            cylinder.position = Vector3.MoveTowards(cylinder.position, initialPosition, pressSpeed * Time.deltaTime);
            yield return null;
        }
        cylinderRenderer.material.color = originalColor;
        IsPressed = false;
        OnButtonRelease?.Invoke();
    }
}
