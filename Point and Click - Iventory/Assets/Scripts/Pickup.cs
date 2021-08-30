using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private NewItems effect;


    private void Awake()
    {
        effect=GetComponent<NewItems>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnMouseDown()
    {
        if (effect.CanTake==true)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
            Debug.Log("Enter for loop");          
                if (inventory.isFull[i]==false){
                    inventory.addItem(inventory.nextAvailable(),effect);
                    inventory.isFull[i]=true;
                    Instantiate(effect, transform.position, Quaternion.identity);
                    Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Destroy(effect);
                    break;
                }            
            }  
        }
        if (effect.CanInteract==true)
        { 
            if (effect.RequiredItem=="")
            {
                Debug.Log("Positive");
            }
            else
            {
                for(int i=0; i<inventory.Items.Count; i++)
                {
                    if (inventory.Items[i].ItemName == effect.RequiredItem)
                    {
                        Debug.Log("Matched");
                    }
                }
            }
        }       
    }
}
