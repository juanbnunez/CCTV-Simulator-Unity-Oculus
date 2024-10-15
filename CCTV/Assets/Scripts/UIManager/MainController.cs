/*-----------------------------------------------------------------------------
    MainController.cs

    This script controls the behavior of 
    Author: Juan Núñez
    Creation: 15-09-2024
    Modification:09-10-2024

-----------------------------------------------------------------------------*/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class MainController : MonoBehaviour
{
    // Public Variables

    // Reference to the ScreenManager that handles switching RenderTextures.
    public ScreenManager screenManager;

    // Button controllers to trigger specific camera and UI actions.
    public PressButton nextButton, backButton, upButton, downButton, leftButton, rightButton;

    // Material to apply the selected RenderTexture
    public Material screenMaterial;

    // Current index to track the active RenderTexture and associated CameraController.
    public int currentTextureIndex = 0;

    // List of CameraControllers, each controlling a specific camera's behavior.
    public List<CameraController> cameraControllers;

    // List of RenderTextures that are applied to the screen material and linked to different cameras.
    public List<RenderTexture> renderTextures;

    //  Enumeration to select the correct rotation
    public enum CameraDirection { Up, Down, Left, Right }

    /// <summary>
    /// Initializes the button press event bindings to their respective camera control functions.
    /// </summary>
    void Start()
    {
        BindButtonEvent(nextButton, NextCamera);
        BindButtonEvent(backButton, PreviousCamera);
        BindButtonEvent(upButton, () => RotateCamera(CameraDirection.Up));
        BindButtonEvent(downButton, () => RotateCamera(CameraDirection.Down));
        BindButtonEvent(leftButton, () => RotateCamera(CameraDirection.Left));
        BindButtonEvent(rightButton, () => RotateCamera(CameraDirection.Right));
    }

    /// <summary>
    /// Check if the the button is binned to an action
    /// </summary>
    /// <param name="button"></param>
    /// <param name="action"></param>
    private void BindButtonEvent(PressButton button, UnityAction action)
    {
        try
        {
            if (button != null)
                button.OnButtonPress.AddListener(action);
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error binding button event: {ex.Message}");
        }
    }

    /// <summary>
    /// Switches to the next camera in the list and updates the render texture on the screen.
    /// </summary>
    public void NextCamera()
    {
        screenManager.NextRenderTexture(currentTextureIndex, renderTextures, screenMaterial);
        currentTextureIndex = (currentTextureIndex + 1) % cameraControllers.Count;
    }

    /// <summary>
    /// Switches to the previous camera in the list and updates the render texture on the screen.
    /// </summary>
    public void PreviousCamera()
    {
        screenManager.PreviousRenderTexture(currentTextureIndex, renderTextures, screenMaterial);
        currentTextureIndex = (currentTextureIndex - 1 + cameraControllers.Count) % cameraControllers.Count;
    }

    /// <summary>
    /// Rotates the current camera by triggering the function of the active CameraController.
    /// </summary>
    /// <param name="direction"></param>
    public void RotateCamera(CameraDirection direction)
    {
        if (currentTextureIndex < cameraControllers.Count)
        {
            switch (direction)
            {
                case CameraDirection.Up:
                    cameraControllers[currentTextureIndex].RotateUp();
                    break;
                case CameraDirection.Down:
                    cameraControllers[currentTextureIndex].RotateDown();
                    break;
                case CameraDirection.Left:
                    cameraControllers[currentTextureIndex].RotateLeft();
                    break;
                case CameraDirection.Right:
                    cameraControllers[currentTextureIndex].RotateRight();
                    break;
            }
        }
    }

}
