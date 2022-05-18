using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    private const float TargetSizeX = 1280.0f;
    private const float TargetSizeY = 720.0f;
    private const float HalfSize = 200.0f;

    private void Awake()
    {
        CameraResize();
    }
    private void CameraResize()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = TargetSizeX / TargetSizeY;

        if (screenRatio >= targetRatio)
        {
            Resize();
        }
        else
        {
            float differentSize = targetRatio / screenRatio;
            Resize(differentSize);
        }
    }

    private void Resize(float differentSize = 1.0f)
    {
        Camera.main.orthographicSize = TargetSizeY / TargetSizeX * differentSize;
    }
}

