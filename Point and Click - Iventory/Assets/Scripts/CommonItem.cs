using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonItem : NewItems
{
    private StoryElement element;

    public override void Awake()
    {
        element = GetComponent<StoryElement>();
    } 

    public override void  Interaction(){
        if (requiredItem=="")
        {
            Debug.Log("Positive");
            element.TriggerDialogue();
        }
    }
}
