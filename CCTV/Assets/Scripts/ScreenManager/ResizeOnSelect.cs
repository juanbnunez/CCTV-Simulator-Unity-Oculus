using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ResizeOnSelect : MonoBehaviour, IPointerClickHandler
{
    public float scaleFactor = 2.5f; // Factor de escala cuando se selecciona
    public float animationDuration = 0.5f; // Duración de la animación en segundos
    private Vector3 originalScale;
    private Vector3 originalPosition; // Guardar la posición original
    private bool isAnimating = false; // Para controlar si la animación está en progreso

    void Start()
    {
        originalScale = transform.localScale;
        originalPosition = transform.localPosition; // Guarda la posición local original
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) > 0.5f)
        {
            if (!isAnimating)
            {
                StartCoroutine(AnimateScale());
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isAnimating)
        {
            StartCoroutine(AnimateScale());
        }
    }

    IEnumerator AnimateScale()
    {
        isAnimating = true;
        float currentTime = 0f;
        Vector3 startScale = transform.localScale;
        Vector3 targetScale = (transform.localScale == originalScale) ? originalScale * scaleFactor : originalScale;
        Vector3 startPosition = transform.localPosition;
        Vector3 targetPosition = (transform.localScale == originalScale) ? Vector3.zero : originalPosition;

        while (currentTime < animationDuration)
        {
            currentTime += Time.deltaTime;
            transform.localScale = Vector3.Lerp(startScale, targetScale, currentTime / animationDuration);
            transform.localPosition = Vector3.Lerp(startPosition, targetPosition, currentTime / animationDuration);
            yield return null;
        }

        transform.localScale = targetScale; // Asegura que la escala final es exactamente el deseado
        transform.localPosition = targetPosition; // Asegura la posición final en el centro o original
        isAnimating = false;
    }
}
