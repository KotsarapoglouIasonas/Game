using System.Collections;
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
    private DigitalDisplay display;
    private LoadScene loadscene;
    private StoryElement element;


    private void Awake()
    {
        display=FindObjectOfType<DigitalDisplay>();
        newItem=GetComponent<NewItems>();
        spawnItem=GetComponent<Spawn>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        loadscene = GameObject.FindGameObjectWithTag("Player").GetComponent<LoadScene>();
    }

    private void OnMouseDown()
    {   


        
        if (!EventSystem.current.IsPointerOverGameObject () )
        {
            if (newItem.GetComponent<StoryElement>()!=null)
            {
                element = newItem.GetComponent<StoryElement>();
            }
            if (newItem.CanInteract==true)
            {
                inventory.AddDialogue(element.Gdialogue); 
                newItem.Interaction();
            }
            if (newItem.CanTake==true)
            {
                for (int i = 0; i < inventory.slots.Length; i++)
                {         
                    if (inventory.isFull[i]==false)
                    {   if (newItem.tag == "CarItem")
                        {
                            inventory.AddToCar(newItem.ItemName);
                        }
                        if (inventory.Keys.ContainsKey(newItem.ItemName))
                        {
                            loadscene.AddScene(inventory.Keys[newItem.ItemName]);
                        }
                        if (newItem.tag == "key")
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
            }
        }       
    }
}
