using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float move_speed = 3;

    private Vector2 movement;
    private Rigidbody2D rb2d;
    private bool left;
    private bool right;
    private bool up;
    private bool down;
    private Animator anim;
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        PlayerAnimate();
    }
    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        PlayerMove();
    }
    void PlayerMove()
    {
        rb2d.MovePosition(rb2d.position + movement * move_speed * Time.deltaTime);
    }
    void PlayerAnimate()
    {
        if(movement.x > 0)
        {
            right = true;
            left = false;
            up = false;
            down = false;
        }
        if(movement.x < 0)
        {
            right = false;
            left = true;
            up = false;
            down = false;
        }
        if(movement.y > 0)
        {
            right = false;
            left = false;
            up = false;
            down = true;
        }
        if(movement.y < 0)
        {
            right = false;
            left = false;
            up = true;
            down = false;
        }
        anim.SetBool("up", up);
        anim.SetBool("down", down);
        anim.SetBool("right", right);
        anim.SetBool("left", left);
    }
    
}
