using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public float lag = 0.3f;

    Vector3 newPosition;

    void FixedUpdate()
    {
        // position
        newPosition = target.position - target.forward * 90f + target.up * 25f;
        transform.position = Vector3.Slerp(transform.position, newPosition, lag);
        // rotation
        transform.LookAt(target.position + target.forward * 2000f);
    }
}
