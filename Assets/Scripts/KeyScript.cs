using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private DialogueTrigger dialogue_trigger;
    void Start()
    {
        dialogue_trigger = gameObject.GetComponent<DialogueTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            dialogue_trigger.TriggerDialogue();
        }
    }
}
