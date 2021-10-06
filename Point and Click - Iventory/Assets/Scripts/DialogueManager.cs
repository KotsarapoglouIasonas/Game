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
    [SerializeField] private Queue<string> names;

    void Start()
    {
        panel.gameObject.SetActive(false);
        sentences=new Queue<string>();
        names=new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //animator.SetBool("isOpen",true);
        //Debug.Log("Starting Conversation with : "+dialogue.ObjectName.ToString());
        panel.SetActive(true);
        //nameText.text=dialogue.ObjectName;
        names.Clear();
        sentences.Clear();

        foreach(string name in  dialogue.Names)
        {
            names.Enqueue(name);
        }
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
        string name=names.Dequeue();
        //Debug.Log(sentence);
        //dialogueText.text=sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence,name));
    }
    IEnumerator TypeSentence(string sentence,string name)
    {
        dialogueText.text="";
        nameText.text="";
        foreach(char letter in name.ToCharArray())
        {
            nameText.text+=letter;
            yield return null;
        }
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
