using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float finalMealRotationSpeed;

    void Update()
    {
        RotateHandler();
    }
    void RotateHandler()
    {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * finalMealRotationSpeed);
    }
}