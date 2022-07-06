using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movment;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {   //Input
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal",movment.x);
        animator.SetFloat("Vertical",movment.y);
        animator.SetFloat("Speed",movment.sqrMagnitude);
    }

    void FixedUpdate() 
    {   //Movment
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
    }
}
