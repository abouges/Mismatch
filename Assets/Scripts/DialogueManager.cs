using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    
    public Text name_text;
    public Text dialogue_text;

    public Animator anim;
    public AudioSource dialogue_audio;

    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        anim.SetBool("is_open", true);

        name_text.text = dialogue.character_name;

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
       
    }
    public void DisplayNextSentence()
    {
        
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    void EndDialogue()
    {
        anim.SetBool("is_open", false);
    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogue_audio.Play();
        dialogue_text.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogue_text.text += letter;
            yield return null;
        }
        dialogue_audio.Stop();
    }

}
