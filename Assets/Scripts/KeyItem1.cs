using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
	{
        if(collider.tag == "Player")
		{
            ItemUI.instance.ItemOne();
			GameVariables.keyType = 1;
			Destroy(gameObject);
		}
	}
}
