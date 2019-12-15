using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem3 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            ItemUI.instance.ItemOne();
            GameVariables.keyType = 3;
            Destroy(gameObject);
        }
    }
}
