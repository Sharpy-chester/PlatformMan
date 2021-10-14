using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float movementSpeed;
    [SerializeField] float maxMovementSpeed;
    Rigidbody2D rb;


    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        
        if (Input.GetAxis("Horizontal") != 0 && rb.velocity.x < maxMovementSpeed)
        {
            rb.AddForce(new Vector2((movementSpeed * Time.deltaTime) * Input.GetAxis("Horizontal"), 0));
        }
    }
}
