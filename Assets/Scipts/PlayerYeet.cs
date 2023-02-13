using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYeet : MonoBehaviour
{
    // initializing variables 
    public float speed = 2f;
    public GameObject WinText;
    public GameObject LoseText;
    bool win_game = true;
    public int win_time = 10000;
    float time_counter = 0;

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

        // iterate the time counter to count the frames 
        time_counter++;

        // if the player didn't get destroyed & survives all the astroids, they get the win
        if (win_game == true)
        {
            // Once the time is up, active the win text 
            if (time_counter == win_time)
            {
                WinText.SetActive(true);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // if player collides with anything, the turso gets destroyed & text is active stating
         // that the player lost 
        Destroy(gameObject);
        LoseText.SetActive(true);
        win_game = false;
    }
}
