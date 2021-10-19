using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerScript : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    bool _isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity = new Vector3(-2, 0, 0);
        if (Input.GetKey(KeyCode.S))
            rb.velocity = new Vector3(2, 0, 0);
        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector3(0, 0, -2);
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector3(0, 0, 2);

    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }
    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}
