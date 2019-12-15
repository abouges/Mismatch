using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem1 : MonoBehaviour
{
    public Rigidbody2D Key1;
    public Rigidbody2D Key2;
    public Rigidbody2D Key3;


    
    void OnTriggerEnter2D(Collider2D collider)
	{
        if (collider.tag == "Player")
		{
           /* ItemUI.instance.dropped = false;
            if (PlayerControl.instance.currentKey == 0)
            {
                print("no keys");
                PlayerControl.instance.currentKey = 1;
            }
            else if (PlayerControl.instance.currentKey > 0)
            {
                print("some keys");
                ItemUI.instance.Switch(PlayerControl.instance.currentKey);
                StartCoroutine(CoolDown());
                PlayerControl.instance.currentKey = 1;
            }
            */
            GameVariables.keyType = 1;
            ItemUI.instance.ItemOne();
            Destroy(gameObject);
		}
	}
}
