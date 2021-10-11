using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : NewItems
{
    private StoryElement element;
    private Spawn spawnItem;

    public override void Awake()
    {
        element = GetComponent<StoryElement>();
        spawnItem = GetComponent<Spawn>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public override void Interaction()
    {
        if (requiredItem!="")
        {
            if (inventory.ActiveItem==requiredItem)
            {
                spawnItem.SpawnItem();
            }
        }
        else
        {
            spawnItem.SpawnItem();
            element.TriggerDialogue();
        }
    }
}
