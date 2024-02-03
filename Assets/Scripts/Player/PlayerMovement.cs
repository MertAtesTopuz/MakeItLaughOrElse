using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public Vector2 movement;
    private Rigidbody2D rb;
    public float speed = 5;
    private Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        anim.SetFloat("moveX", movement.x);
        anim.SetFloat("moveY", movement.y);

        if (movement.x == 1 || movement.x == -1 || movement.y == 1 || movement.y == -1)
        {
            anim.SetFloat("lastMoveX", movement.x);
            anim.SetFloat("lastMoveY", movement.y);
        }
    }
}
