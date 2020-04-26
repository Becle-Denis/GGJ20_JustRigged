using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnCollision : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<Manager>().RestartScene();
        }
    }
}
