﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private NewItems newItem;


    private void Awake()
    {
        newItem=GetComponent<NewItems>();
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
                    Instantiate(newItem, transform.position, Quaternion.identity);
                    //Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    GameObject newButton_GO = Instantiate(itemButton, inventory.slots[i].transform, false);
                    Button newButton=newButton_GO.GetComponent<Button>();
                    newButton.onClick.AddListener(delegate{newItem.UseItem();});
                    Image newButtonImage=newButton_GO.GetComponent<Image>();
                    newButtonImage.sprite=newItem.InventoryImage;
                    Destroy(gameObject);
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
                Debug.Log(inventory.ActiveItem.ToString());
                if (inventory.ActiveItem==newItem.RequiredItem)
                {
                    Debug.Log("Matched");
                }
            }
        }       
    }
}
