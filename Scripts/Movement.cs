using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 30f;

    Vector3 movement;
    void Update() 
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }


}
