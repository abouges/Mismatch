using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Win");
            PlayerWins.instance.Win();
        }
    }
}
