using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem2 : MonoBehaviour
{
    public Rigidbody2D Key1;
    public Rigidbody2D Key2;
    public Rigidbody2D Key3;

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(GameVariables.keyType);

        if (collider.tag == "Player")
        /*{
            ItemUI.instance.dropped = false;
            if (PlayerControl.instance.currentKey == 0)
            {
                PlayerControl.instance.currentKey = 2;
            }
            else if (PlayerControl.instance.currentKey > 0)
            {
                print("some keys 2");
                ItemUI.instance.Switch(PlayerControl.instance.currentKey);
                PlayerControl.instance.currentKey = 2;
            }
 */

            GameVariables.keyType = 2;
            ItemUI.instance.ItemTwo();
            
            Destroy(gameObject);
        }
    }
