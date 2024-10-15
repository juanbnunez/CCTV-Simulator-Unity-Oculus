using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera cameraToChange;
    public RenderTexture[] renderTextures;
    private int currentTextureIndex = 4;

    void Start()
    {
        if (cameraToChange == null)
        {
            Debug.LogError("No se ha asignado la cámara en el Inspector.");
            return;
        }

        if (renderTextures == null || renderTextures.Length == 0)
        {
            Debug.LogError("No se han asignado RenderTextures en el Inspector.");
            return;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cambia a la siguiente RenderTexture en el array
            currentTextureIndex = (currentTextureIndex + 1) % renderTextures.Length;
            cameraToChange.targetTexture = renderTextures[currentTextureIndex];
        }
    }
}
