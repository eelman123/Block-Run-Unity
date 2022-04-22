using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    Vector3 movement;

    public string direction = "up";

    public float top = 50f;

    public float bottom = 8.5f;

    public float right = 10f;

    public float left = -10f;

    // Update is called once per frame
    void Update()
    {   
        if (direction == "up") 
        {
            movement.y = 0.5f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

            if (rb.position.y > top) {
                direction = "down";
            }
        } else if (direction == "down")
        {
            
            movement.y = -0.5f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
            if (rb.position.y < bottom) {
                direction = "up";
            }
        } else if (direction == "right")
        {
            movement.x = 0.5f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

            if (rb.position.x > right) {
                direction = "left";
            }

        } else if (direction == "left")
        {
            movement.x = -0.5f;
            rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

            if (rb.position.x < left) {
                direction = "right";
            }
        }


    }
}
