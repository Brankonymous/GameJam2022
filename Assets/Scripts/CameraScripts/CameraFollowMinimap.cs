using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMinimap : MonoBehaviour
{
    public Transform followTransform;

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, -750);
    }
}