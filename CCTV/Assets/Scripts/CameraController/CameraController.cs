using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public Transform swivelTransform;
    public Transform angleTransform;

    private float xSwivel, ySwivel, zSwivel;
    private float xAngle, yAngle, zAngle;

    void Start()
    {
        InitializeCameras();
    }

    public void InitializeCameras()
    {
        xAngle = angleTransform.eulerAngles.x;
        yAngle = angleTransform.eulerAngles.y;
        zAngle = angleTransform.eulerAngles.z;

        xSwivel = swivelTransform.eulerAngles.x;
        ySwivel = swivelTransform.eulerAngles.y;
        zSwivel = swivelTransform.eulerAngles.z;
    }

    // Rotations
    public void RotateLeft()
    {
        ySwivel -= rotationSpeed * Time.deltaTime;
        swivelTransform.rotation = Quaternion.Euler(xSwivel, ySwivel, zSwivel);
    }

    public void RotateRight()
    {
        ySwivel += rotationSpeed * Time.deltaTime;
        swivelTransform.rotation = Quaternion.Euler(xSwivel, ySwivel, zSwivel);
    }

    public void RotateUp()
    {
        xAngle -= rotationSpeed * Time.deltaTime;
        xAngle = Mathf.Clamp(xAngle, 0.0f, 35f);
        angleTransform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
    }

    public void RotateDown()
    {
        xAngle += rotationSpeed * Time.deltaTime;
        xAngle = Mathf.Clamp(xAngle, 0.0f, 35f);
        angleTransform.rotation = Quaternion.Euler(xAngle, yAngle, zAngle);
    }

}
