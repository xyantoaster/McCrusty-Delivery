using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject target;

    // LateUpdate is called every frame as late as possible
    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
    }
}
