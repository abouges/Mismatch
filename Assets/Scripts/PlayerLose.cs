using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    public static PlayerLose instance;

    public GameObject LoseScreen;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lose()
    {
        LoseScreen.SetActive(true);
        StartCoroutine(Loss());
    }
    IEnumerator Loss()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
