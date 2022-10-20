using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 3.0f;
    public Vector3 offset;
    public Transform LookTarget;


    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position =

        Vector3 dpos = target.position + offset;
        Vector3 spos = Vector3.Lerp(transform.position, dpos, smoothSpeed * Time.deltaTime);
        transform.position = spos;
        transform.LookAt(LookTarget.position);
    }
}
