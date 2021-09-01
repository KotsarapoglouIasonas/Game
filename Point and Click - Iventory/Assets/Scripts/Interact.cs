using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Interact : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private NewItems newItem;
    private Spawn spawnItem;


    private void Awake()
    {
        newItem=GetComponent<NewItems>();
        spawnItem=GetComponent<Spawn>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnMouseDown()
    {
        if (newItem.CanTake==true)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
            Debug.Log("Enter for loop");          
                if (inventory.isFull[i]==false)
                {
                    inventory.addItem(inventory.nextAvailable(),newItem);
                    inventory.isFull[i]=true;
                    GameObject newButton_GO = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Button newButton=newButton_GO.GetComponent<Button>();
                    newButton.onClick.AddListener(delegate{newItem.UseItem();});
                    Image newButtonImage=newButton_GO.GetComponent<Image>();
                    newButtonImage.sprite=newItem.InventoryImage;
                    gameObject.SetActive(false);
                    break;
                }            
            }  
        }
        if (newItem.CanInteract==true)
        { 
            if (newItem.RequiredItem=="")
            {
                Debug.Log("Positive");
            }
            else
            {
                if (inventory.ActiveItem!=newItem.RequiredItem)
                {
                    Debug.Log("You need : "+newItem.RequiredItem.ToString()+" If you want to interract with this item");
                }
                if (inventory.ActiveItem==newItem.RequiredItem)
                {
                    Debug.Log("Matched");
                    if (newItem.ItemName=="treasure")
                    {
                        spawnItem.SpawnItem();
                    }
                }
            }
        }       
    }
}
