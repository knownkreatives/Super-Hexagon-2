using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;

    public float bufferSpeed;
    public Vector3 offset;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smothedPosition = Vector3.Lerp(transform.position, desiredPosition, bufferSpeed);

        transform.position = smothedPosition;

        transform.LookAt(target);
    }
}
