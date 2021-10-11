using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    public Dialogue Gdialogue
    {
        get
        {
            return dialogue;
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
