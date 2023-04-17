using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset = new Vector3(0f, 0f, -10f);
    Vector3 velocity = Vector3.zero;
    float time = 0.25f;

    [SerializeField]
    Transform playerTransform;

    private void Update()
    {
        Vector3 targetPos = playerTransform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity , time);
    }
}
