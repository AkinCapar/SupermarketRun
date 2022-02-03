using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineRotator : MonoBehaviour
{
    [SerializeField] float shineEffectRotationSpeed;
    void Update()
    {
        ShineEffectRotator();
    }

    void ShineEffectRotator()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * shineEffectRotationSpeed);
    }
}
