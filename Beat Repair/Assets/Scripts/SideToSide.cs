using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{
    private Vector3 m_startPos;
    private int m_count = 300;//Number of Frames to Apply change. One second in one direction
    public float m_offsetPerFrame = 10;//Change this to set the offset in pixels. It will be diveded appropriately Below.
    void Start()
    {
        m_offsetPerFrame = m_offsetPerFrame / 60;
        m_startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        m_count--;
        if (m_count != 0)
        {
            transform.position = transform.position + new Vector3(m_offsetPerFrame,0 , 0);
        }
        else
        {
            m_count = 600;//Two seconds. One to reach back to the start point, Another to move past it.
            m_offsetPerFrame = m_offsetPerFrame * -1;
        }
    }
}
