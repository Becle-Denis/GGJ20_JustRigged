using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Manager : MonoBehaviour
{
    
    public void RestartScene()
    {
        //reset each transform 
        Restarter[] restarters = FindObjectsOfType<Restarter>();
        foreach (Restarter r in restarters)
        {
            if (r.first)
            {
                r.Restart();
            }
        }

        foreach (Restarter r in restarters)
        {
            if (!r.first)
            {
                r.Restart();
            }
        }

        //enable each object 
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (!EditorUtility.IsPersistent(go.transform.root.gameObject) && !(go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave))
            {
                go.SetActive(true);
            }
        }

        //reset the ship state
        FindObjectOfType<ComponentHandler>().Restart();
        FindObjectOfType<ShipControls>().Restart();
    }
}
