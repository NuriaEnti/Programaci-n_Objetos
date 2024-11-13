using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CustomShaderData : MonoBehaviour
{
    int frame;
    void Update()
    {
        frame++;
        Shader.SetGlobalInt("_FrameCount", frame);
    }
}
