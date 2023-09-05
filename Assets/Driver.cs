using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [Header("Movement Variables")]
    [SerializeField] public float turnSpeed = 0.5f;
    [SerializeField] public float moveSpeed = 1;
    void Start()
    {
    }

    void Update()
    {
        float steerAmt = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float driveSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmt);
        transform.Translate(0, driveSpeed, 0);
    }
}
