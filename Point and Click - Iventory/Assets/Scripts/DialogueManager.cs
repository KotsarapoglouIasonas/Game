using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Animator animator;
    public Text nameText;
    public Text dialogueText;
    [SerializeField] private Queue<string> sentences;

    void Start()
    {
        sentences=new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("isOpen",true);
        //Debug.Log("Starting Conversation with : "+dialogue.ObjectName.ToString());
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
        animator.SetBool("isOpen",false);
    }

}
