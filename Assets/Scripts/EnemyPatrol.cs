using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    bool up;
    bool down;
    bool left;
    bool right;

    void Start()
    {
        up = true;
    }

    void Update()
    {
        patrol();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Up")
        {
            up = true;
            down = false;
            left = false;
            right = false;
        }
        if (collider.tag == "Down")
        {
            up = false;
            down = true;
            left = false;
            right = false;
        }
        if (collider.tag == "Left")
        {
            up = false;
            down = false;
            left = true;
            right = false;
            Debug.Log("left" + left);
        }
        if (collider.tag == "Right")
        {
            up = false;
            down = false;
            left = false;
            right = true;
        }
        if(collider.tag == "Player")
        {
            PlayerLose.instance.Lose();
        }
    }

    public void patrol()
    {
        if (up == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (down == true)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (right == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (left == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }


}
