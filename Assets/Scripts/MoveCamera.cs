using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MoveCamera : MonoBehaviour
{

    public Transform cameraPostion;

    void Update()
    {
        transform.position = cameraPostion.position;
    }
}
