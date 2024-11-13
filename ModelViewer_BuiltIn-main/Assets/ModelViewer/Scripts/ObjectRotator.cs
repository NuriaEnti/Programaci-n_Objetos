using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Vector3 rotationSpeed;
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
