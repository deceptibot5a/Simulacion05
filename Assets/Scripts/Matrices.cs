using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrices : MonoBehaviour
{
    [SerializeField] Vector4 location;
    void Start() {
        
    }

    void Update() {
        Matrix4x4 matrix = new Matrix4x4(new Vector4(1, 0, 0, 0), new Vector4(0, 1, 0, 0), new Vector4(0, 0, 1, 0), location);
        Vector4 localPosition = transform.localPosition;
        localPosition.w = 1;
        transform.localPosition = matrix * localPosition;
    }
}
