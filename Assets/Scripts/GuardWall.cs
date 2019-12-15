﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardWall : MonoBehaviour
{
	private DialogueTrigger dialogue_trigger;
	void Start()
	{
		dialogue_trigger = gameObject.GetComponent<DialogueTrigger>();
	}
	// Update is called once per frame

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" && GameVariables.keyType != 1)
		{
			Debug.Log("Dialogue");
			dialogue_trigger.TriggerDialogue();
		}
	}


	void Update()
	{

		if (GameVariables.keyType == 1)
		{
			GetComponent<BoxCollider2D>().isTrigger = true;
        }
	}

 }
