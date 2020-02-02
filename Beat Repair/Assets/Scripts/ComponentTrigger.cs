using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentTrigger : MonoBehaviour
{
    public GameObject ShipContainer;
    public int ComponentID = 0;
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            ShipContainer.GetComponent<ComponentHandler>().setCurrentComponent(ComponentID);
        }
       
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            ShipContainer.GetComponent<ComponentHandler>().setCurrentComponent(0);
        }
    }

}
