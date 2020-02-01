using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    public float spinningSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, (spinningSpeed * Time.deltaTime) % 360));
    }
}
