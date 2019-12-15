using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float move_speed = 3;

    private Vector2 movement;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
    public void KeyPickup()
    {

    }
    public void FoundCompanion()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Companion")
        {
            FoundCompanion();
        }
    }
}
