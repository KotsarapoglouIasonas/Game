using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonItem : NewItems
{
    private StoryElement element;
    private Inventory inventory;

    public override void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        element = GetComponent<StoryElement>();
    } 

    public override void  Interaction(){
        if (requiredItem=="")
        {
            Debug.Log("Positive");
            element.TriggerDialogue();
        }
    }

    public override void UseItem()
    {
        inventory.ActiveItem=this.itemName;
        Debug.Log("Holding item changed");
    }
}
