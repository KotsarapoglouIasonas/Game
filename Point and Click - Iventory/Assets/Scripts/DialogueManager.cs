using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text nameText;
    [SerializeField] private Text dialogueText;
    [SerializeField] private Queue<string> sentences;

    void Start()
    {
        panel.gameObject.SetActive(false);
        sentences=new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //animator.SetBool("isOpen",true);
        //Debug.Log("Starting Conversation with : "+dialogue.ObjectName.ToString());
        panel.SetActive(true);
        nameText.text=dialogue.ObjectName;
        sentences.Clear();
        foreach(string sentence in  dialogue.Sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        string sentence=sentences.Dequeue();
        //Debug.Log(sentence);
        //dialogueText.text=sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text="";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text+=letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End of the conversation");
        panel.SetActive(false);
        //animator.SetBool("isOpen",false);
    }

}
