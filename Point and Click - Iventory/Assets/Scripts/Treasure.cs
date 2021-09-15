using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : NewItems
{
    private StoryElement element;
    private Spawn spawnItem;

    public override void Awake()
    {
        element = FindObjectOfType<StoryElement>();
        spawnItem = GetComponent<Spawn>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public override void Interaction()
    {
        if (inventory.ActiveItem==requiredItem)
        {
            Debug.Log("Matched");
            spawnItem.SpawnItem();
        }
        else
        {
            element.TriggerDialogue();
        }
    }
}
