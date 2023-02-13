using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYeet : MonoBehaviour
{
    // initializing variables 
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //// player movement //// 
        // initilize position variable 
        Vector3 newPos = transform.position;

        // WASD controller 
        if (Input.GetKey(KeyCode.W))
        {
            newPos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += speed * Time.deltaTime;
        }

        // setting the new position 
        transform.position = newPos;

        /*
        // if players press the space key
        if (Input.GetMouseButtonDown(0))
        {
            // find click position 
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // set player position to mouse position
            transform.position = mousePos; 
        }
        */
    }
}
