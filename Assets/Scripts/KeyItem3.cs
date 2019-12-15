using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem3 : MonoBehaviour
{
    public Rigidbody2D Key1;
    public Rigidbody2D Key2;
    public Rigidbody2D Key3;

    void OnTriggerEnter2D(Collider2D collider)
    {
       
                Debug.Log(GameVariables.keyType);

                if (collider.tag == "Player")
                {
                   /* ItemUI.instance.dropped = false;
                    if (PlayerControl.instance.currentKey == 0)
                    {
                        PlayerControl.instance.currentKey = 3;
                    }
                    else if (PlayerControl.instance.currentKey > 0)
                    {
                        print("some keys 3");
                        ItemUI.instance.Switch(PlayerControl.instance.currentKey);
                        PlayerControl.instance.currentKey = 3;
                    }

            */
        GameVariables.keyType = 3;
            ItemUI.instance.ItemThree();
            Destroy(gameObject);
        }
    }
}
