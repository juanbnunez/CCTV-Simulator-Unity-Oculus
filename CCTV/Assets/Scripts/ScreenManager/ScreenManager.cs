using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    /// <summary>
    /// Switches to the next RenderTexture in the list.
    /// Increments the current index and loops back to the first texture when the end of the list is reached.
    /// </summary>
    /// <param name="currentTextureIndex">The current index of the active RenderTexture.</param>
    /// <param name="renderTextures">A list containing the available RenderTextures.</param>
    /// <param name="screenMaterial">The material on which the RenderTexture is displayed.</param>
    public void NextRenderTexture(int currentTextureIndex, List<RenderTexture> renderTextures, Material screenMaterial)
    {
        currentTextureIndex++; // Increase index

        if (currentTextureIndex >= renderTextures.Count)
        {
            currentTextureIndex = 0; // If at end, go back to the start of the list
        }

        // Call ChangeRenderTexture with the correct parameters
        ChangeRenderTexture(screenMaterial, currentTextureIndex, renderTextures);
    }

    /// <summary>
    /// Switches to the previous RenderTexture in the list.
    /// Decrements the current index and loops back to the last texture when the start of the list is reached.
    /// </summary>
    /// <param name="currentTextureIndex">The current index of the active RenderTexture.</param>
    /// <param name="renderTextures">A list containing the available RenderTextures.</param>
    /// <param name="screenMaterial">The material on which the RenderTexture is displayed.</param>
    public void PreviousRenderTexture(int currentTextureIndex, List<RenderTexture> renderTextures, Material screenMaterial)
    {
        currentTextureIndex--; // Decrease index

        if (currentTextureIndex < 0)
        {
            currentTextureIndex = renderTextures.Count - 1; // If at the start, go back to the end of the list
        }

        // Call ChangeRenderTexture with the correct parameters
        ChangeRenderTexture(screenMaterial, currentTextureIndex, renderTextures);
    }

    /// <summary>
    /// Updates the main texture of the provided material with the RenderTexture at the specified index.
    /// </summary>
    /// <param name="screenMaterial">The material to apply the RenderTexture to.</param>
    /// <param name="index">The index of the RenderTexture to use from the list.</param>
    /// <param name="renderTextures">A list containing the available RenderTextures.</param>
    public void ChangeRenderTexture(Material screenMaterial, int index, List<RenderTexture> renderTextures)
    {
        if (screenMaterial != null && renderTextures[index] != null)
        {
            screenMaterial.mainTexture = renderTextures[index];
        }
    }
}
