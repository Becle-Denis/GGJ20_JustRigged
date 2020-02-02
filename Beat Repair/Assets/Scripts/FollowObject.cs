using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform objectToFollow;
    public Camera camera;
    public float cameraSize = 5f;
    private float zOffset = -10f;

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = objectToFollow.position + new Vector3(0,0,zOffset);
        camera.orthographicSize = cameraSize;
    }
}
