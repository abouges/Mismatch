using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUI : MonoBehaviour
{
    public static ItemUI instance;

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    private AudioSource KeyAudio;

    void Start()
    {
        instance = this;
        KeyAudio = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void ItemOne()
    {
        Item1.SetActive(true);
        Item2.SetActive(false);
        Item3.SetActive(false);
        KeyAudio.Play();
    }

    public void ItemTwo()
    {
        Item1.SetActive(false);
        Item2.SetActive(true);
        Item3.SetActive(false);
        KeyAudio.Play();
    }

    public void ItemThree()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(true);
        KeyAudio.Play();
    }
}