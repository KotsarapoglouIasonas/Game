﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class Interact : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private NewItems newItem;
    private Spawn spawnItem;
    private StoryElement element;
    private DigitalDisplay display;


    private void Awake()
    {
        display=FindObjectOfType<DigitalDisplay>();
        element=FindObjectOfType<StoryElement>();
        newItem=GetComponent<NewItems>();
        spawnItem=GetComponent<Spawn>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject () )
        {
            if (newItem.CanTake==true)
            {
                for (int i = 0; i < inventory.slots.Length; i++)
                {         
                    if (inventory.isFull[i]==false)
                    {   if( newItem.tag == "CarItem")
                        {
                            inventory.AddToCar(newItem.ItemName);
                        }
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
            newItem.Interaction();
            }
        }       
    }
}
