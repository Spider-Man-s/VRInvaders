using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform camera;

    private void Start()
    {

        camera = Camera.main.transform;
    }

    private void LateUpdate()
    {
        // Ensure the canvas faces the camera
        // Method 1: Directly look at the camera transform
        // transform.LookAt(mainCameraTransform);

        // Method 2: Look in the direction of the camera's forward
        transform.LookAt(transform.position + camera.forward);
    }
}
