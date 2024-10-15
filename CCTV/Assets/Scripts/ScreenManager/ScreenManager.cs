using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    // Cambia a la siguiente Render Texture
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

    // Cambia a la Render Texture anterior
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

    // Cambiar la Render Texture en el material
    public void ChangeRenderTexture(Material screenMaterial, int index, List<RenderTexture> renderTextures)
    {
        if (screenMaterial != null && renderTextures[index] != null)
        {
            screenMaterial.mainTexture = renderTextures[index];
        }
    }
}
