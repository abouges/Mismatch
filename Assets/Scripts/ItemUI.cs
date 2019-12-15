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
    Rigidbody2D currentItem;
    public Rigidbody2D Key1;
    public Rigidbody2D Key2;
    public Rigidbody2D Key3;
    public GameObject Player;
    public GameObject SpawnPoint;
    public bool dropped;
    private Vector3 currentPosition;

    void Start()
    {
        instance = this;
        KeyAudio = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        currentPosition = Player.transform.position;
    }

    public void ItemOne()
    {
       
        Item1.SetActive(true);
        Item2.SetActive(false);
        Item3.SetActive(false);
        KeyAudio.Play();
        //print("exchange call.");
        //exchangeItem(1);
        //currentItem = Key1.GetComponent<Rigidbody2D>();
    }

    public void ItemTwo()
    {
        Item1.SetActive(false);
        Item2.SetActive(true);
        Item3.SetActive(false);
        KeyAudio.Play();
        //currentItem = Key2.GetComponent<Rigidbody2D>();
    }

    public void ItemThree()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(true);
        KeyAudio.Play();
    }

    public void UseItem()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
    }

  /*  public void exchangeItem(int currentItemNumber)
    {
        if (currentItemNumber == 1)
        {
            //Rigidbody2D drop;
            //drop = Instantiate(Key2, Player.transform.position, Player.transform.rotation);
            print("has key 1");
            print("current = " + currentItemNumber);
        }
        if (currentItemNumber == 2)
        {
            print("has key 2");
        }
        if (currentItemNumber == 3)
        {
            print("has key 3");
        }
    }

    public void Switch(int currentKey)
    {
        if (currentKey == 1)
        {
            if(dropped == false)
            {
                Rigidbody2D drop;
                drop = Instantiate(Key1, currentPosition, Player.transform.rotation);
                drop.velocity = new Vector3(0, 1, 0); 
                dropped = true;
            }
        }
        if (currentKey == 2)
        {
            if (dropped == false)
            {
                Rigidbody2D drop;
                drop = Instantiate(Key2, currentPosition, Player.transform.rotation);
                drop.velocity = new Vector3(1, 0, 0);
                dropped = true;
            }
        }
        if (currentKey == 3)
        {
            if (dropped == false)
            {
                Rigidbody2D drop;
                drop = Instantiate(Key3, currentPosition, Player.transform.rotation);
                dropped = true;
            }
        }

    }
    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1);
    }
    */
}
