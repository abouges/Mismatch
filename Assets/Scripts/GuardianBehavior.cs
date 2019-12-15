using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardianBehavior : MonoBehaviour
{
	private DialogueTrigger dialogue_trigger;
	void Start()
	{
		dialogue_trigger = gameObject.GetComponent<DialogueTrigger>();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player" && GameVariables.keyType==1)
		{
			Debug.Log("Dialogue");
			dialogue_trigger.TriggerDialogue();

			GameVariables.keyType = 0;
			Destroy(gameObject);
			Debug.Log("Let through");
            //SceneManager.LoadScene(1);
		}

        if (collider.tag == "Player" && GameVariables.keyType != 1)
		{
			Debug.Log("Cannot let in");
			Debug.Log("Dialogue");
		}
	}
}
