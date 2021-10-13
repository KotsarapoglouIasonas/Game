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
        for (int i=0; i<inventory.Items.Count; i++)
        {
            if (inventory.Items[i] == spawnItem)
            {
                spawnItem=null;
                break;
            }
        }
        if (requiredItem!="")
        {
            if (inventory.ActiveItem==requiredItem)
            {
                element.TriggerDialogue();
                spawnItem.SpawnItem();
            }
            else
            {
                bool exist=false;
                for (int i=0; i<inventory.Items.Count; i++)
                {
                    if (inventory.Items[i].ItemName == requiredItem)
                    {
                        exist=true;
                    }
                }
                if (exist==true)
                {
                    Debug.Log("Please put : "+RequiredItem+" in your hand! By clicking on it ");
                }
                else
                {
                    Debug.Log("You dont have the required item to open it!");
                }
            }
        }
        else
        {
            element.TriggerDialogue();
            spawnItem.SpawnItem();
        }
        
    }

    public override void UseItem()
    {
        inventory.ActiveItem=this.itemName;
        Debug.Log("Holding item changed");
    }

}
