using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static PlayerControl instance;
    public float move_speed = 3;
    public AudioClip walk_audio;

    private Vector2 movement;
    private Rigidbody2D rb2d;

    private bool left;
    private bool right;
    private bool up;
    private bool down;
    private bool is_walking;
    public int currentKey;

    private bool walking_audio_playing;

    private AudioSource player_audio_source;
    private Animator anim;
    void Start()
    {
        instance = this;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        player_audio_source = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        PlayerAnimate();
        audioControl();
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
            is_walking = true;
        }
        if(movement.x < 0)
        {
            right = false;
            left = true;
            up = false;
            down = false;
            is_walking = true;
        }
        if(movement.y > 0)
        {
            right = false;
            left = false;
            up = false;
            down = true;
            is_walking = true;
        }
        if(movement.y < 0)
        {
            
            right = false;
            left = false;
            up = true;
            down = false;
            is_walking = true;
        }
        if(movement.x == 0 && movement.y == 0)
        {
            is_walking = false;
        }
        anim.SetBool("up", up);
        anim.SetBool("down", down);
        anim.SetBool("right", right);
        anim.SetBool("left", left);
    }
    public void audioControl()
    {
        if (is_walking == true && walking_audio_playing == false)
        {
            player_audio_source.clip = walk_audio;
            player_audio_source.Play();
            walking_audio_playing = true;
        }
        if (is_walking == false)
        {
            player_audio_source.Stop();
            walking_audio_playing = false;
        }
    }

}
