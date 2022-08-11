using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;

    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.position = ball.position + offset;
    }
}
