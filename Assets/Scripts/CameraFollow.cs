using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;

    

    void FixedUpdate()
    {
        Vector3 desiredPosition = ball.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 0.5f);
        transform.position = smoothedPosition;
    }
}
