using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWins : MonoBehaviour
{
	public static PlayerWins instance;

	public GameObject WinScreen;
	void Start()
	{
		instance = this;
	}

	// Update is called once per frame
	void Update()
	{

	}
	public void Win()
	{
        Debug.Log("Won");
		WinScreen.SetActive(true);
		StartCoroutine(Won());
	}
	IEnumerator Won()
	{
		yield return new WaitForSeconds(2);
		Application.Quit();
	}
}
