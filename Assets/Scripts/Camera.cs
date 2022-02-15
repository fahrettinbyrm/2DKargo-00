using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject car;


    private void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(0, 0, -10);
    }
}
