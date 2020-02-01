using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningAll : MonoBehaviour
{
    public float spinningSpeedX = 10f;
    public float spinningSpeedY = 10f;
    public float spinningSpeedZ = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3((spinningSpeedX * Time.deltaTime) % 360, (spinningSpeedY * Time.deltaTime) % 360, (spinningSpeedZ * Time.deltaTime) % 360));
    }
}
