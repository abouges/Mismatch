using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardianBehavior3 : MonoBehaviour
{
    private DialogueTrigger dialogue_trigger;
    void Start()
    {
        dialogue_trigger = gameObject.GetComponent<DialogueTrigger>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && GameVariables.keyType == 3)
        {
            Debug.Log("Dialogue");
            dialogue_trigger.TriggerDialogue();

            GameVariables.keyType = 0;
            Destroy(gameObject);
            Debug.Log("Let through");
            //SceneManager.LoadScene(1);
            ItemUI.instance.UseItem();
        }

        if (collider.tag == "Player" && GameVariables.keyType != 3)
        {
            Debug.Log("Cannot let in");
            Debug.Log("Dialogue");
        }
    }
}
