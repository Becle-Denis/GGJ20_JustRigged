﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    public float Speed = 5.0f;
    public bool controllingShip = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controllingShip)
        {

            float translation = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
            float strafe = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
            Vector2 movement = new Vector2(strafe, translation);
            transform.Translate(movement);
            HandleEngine();
        }

    }

    void HandleEngine()
    {
        if (Input.GetKey(KeyCode.W))
        { 
            transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.gameObject.SetActive(true);
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.gameObject.SetActive(false);
        }


    }

    public void Restart()
    {
        transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.SetActive(false);

        transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(false);
        transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(false);

        transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.gameObject.SetActive(false);
    }

}
