using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookMovement : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private Vector3 difference;
    [SerializeField] float sensivity = 0.25f;
    [SerializeField] float moveSpeed = 1f;
    private float xPos;

    private void Update()
    {
        Moving();
        SwerveControl();
    }

    private void Moving()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void SwerveControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            difference = lastMousePosition - Input.mousePosition;
            lastMousePosition = Input.mousePosition;

            xPos = Mathf.Clamp((transform.position.x - (difference.x * sensivity)), -4f, 4f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }
}
