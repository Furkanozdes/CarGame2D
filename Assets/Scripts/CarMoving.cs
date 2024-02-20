using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{

    public float movingSpeed = 5f;
    public float moveForce = 10f;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float movingInput = Input.GetAxis("Horizontal");
        float moveInput = movingInput * movingSpeed;
        rb.velocity = new Vector2 (moveInput, rb.velocity.y);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(moveForce * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-moveForce * Time.deltaTime);
        }
    }
}
