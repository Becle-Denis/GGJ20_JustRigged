using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandlerShip : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ShipContainer;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.layer == 10)
        {
            
            ShipContainer.GetComponent<ComponentHandler>().breakComponent();
            col.gameObject.SetActive(false);
        }

    }
}
