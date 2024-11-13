using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 500;
    public float zoomSpeedAdapt = 1;
    public float zoomAmount = 0;
    public float zoomAmountCurrent = 0;
    public CinemachineMixingCamera mix;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        zoomAmount = Mathf.Clamp01(zoomAmount + Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime);
        zoomAmountCurrent = Mathf.Clamp(Mathf.Lerp(zoomAmountCurrent, zoomAmount, zoomSpeedAdapt * Time.deltaTime), 0.01f, 0.99f);
        mix.m_Weight0 = zoomAmountCurrent;
        mix.m_Weight1 = 1 - zoomAmountCurrent;
    }
}
