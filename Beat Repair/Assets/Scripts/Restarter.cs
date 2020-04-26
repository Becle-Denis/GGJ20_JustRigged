using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    public bool first = true;

    private Quaternion startRotation;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Transform t = GetComponent<Transform>();
        startPosition = t.position;
        startRotation = t.rotation;
    }

    public void Restart()
    {
        Transform t = GetComponent<Transform>();
        t.SetPositionAndRotation(startPosition, startRotation);
    }
}
