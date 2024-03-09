using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target; // Assign the cube object in the Inspector
    public float rotationSpeed = 5.0f;
    public float maxDistance = 10.0f; 
    public float minDistance = 5.0f;

    private Vector3 offset;

    void Start()
    {
        // Calculate initial offset based on desired starting camera position
        offset = transform.position - target.position;
    }

    void LateUpdate()  // LateUpdate to ensure camera moves after other updates
    {
        if (target == null) return;  //Safety check

        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

        offset = Quaternion.AngleAxis(mouseX, Vector3.up) * offset;

        // Optional Zoom (adjust sensitivity as needed)
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        float currentDistance = Vector3.Distance(transform.position, target.position);
        currentDistance = Mathf.Clamp(currentDistance - scrollInput, minDistance, maxDistance);
        offset = offset.normalized * currentDistance; 

        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
