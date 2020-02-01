using System.Collections;
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
        if (Input.GetKey(KeyCode.UpArrow))
        { 
            transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.gameObject.SetActive(true);
        }


        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.gameObject.SetActive(false);
        }


    }

}
