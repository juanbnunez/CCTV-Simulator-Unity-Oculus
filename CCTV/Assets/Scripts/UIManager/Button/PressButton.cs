/*-----------------------------------------------------------------------------
    PressButton.cs

    This script controls the behavior of a button in Unity. When an object
    collides with the button, it presses down, changes color and trigger the camera movement.
    The button then returns to its original position and color when the object leaves.
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

    public UnityEvent OnButtonPress;
    public UnityEvent OnButtonRelease;

    // Public read-only property to check if the button is currently pressed.
    public bool IsPressed { get; private set; } = false;

    // Private Variables
    private Color originalColor;
    private Vector3 initialPosition;
    private Renderer cylinderRenderer;

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
            OnButtonPress?.Invoke();
            StartCoroutine(PressingButton());
        }
    }

    /// <summary>
    /// Coroutine to animate the button press action.
    /// Moves the cylinder down to simulate pressing the button.
    /// </summary>
    /// <returns>An IEnumerator for the coroutine.</returns>
    private IEnumerator PressingButton()
    {
        Vector3 targetPosition = initialPosition - new Vector3(0, pressDepth, 0);
        cylinderRenderer.material.color = pressedColor;
        while (cylinder.position != targetPosition)
        {
            cylinder.position = Vector3.MoveTowards(cylinder.position, targetPosition, pressSpeed * Time.deltaTime);
            yield return null;
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