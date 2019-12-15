using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWins : MonoBehaviour
{
    public AudioSource backgroundAudio;

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
        backgroundAudio.Stop();
		WinScreen.SetActive(true);
		StartCoroutine(Won());
	}
	IEnumerator Won()
	{   
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(0);
	}
}
