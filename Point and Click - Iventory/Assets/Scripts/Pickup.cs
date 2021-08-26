using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    private NewItems effect;
    public NewItems Effect{
        get
        {
            return effect;
        }
    }

    private void Awake()
    {
        effect=GetComponent<NewItems>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < inventory.Limit; i++)
        {
            Debug.Log("Enter for loop");
            if (effect.CanTake){
                inventory.Items.Add(effect.ItemName,effect);
                Instantiate(effect, transform.position, Quaternion.identity);
                Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                Destroy(gameObject);
                break;
            }
        }         
    }
}
