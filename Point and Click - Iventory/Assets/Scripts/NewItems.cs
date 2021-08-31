using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewItems : MonoBehaviour
{
    [SerializeField] private string itemName;
    public string ItemName
    {
        get
        {
            return itemName;
        }
    }
    [SerializeField] private Sprite inventoryImage;
    public Sprite InventoryImage
    {
        get
        {
            return inventoryImage;
        }
    }
    [SerializeField] private Sprite worldImage;
    [SerializeField] private bool canTake;
    public bool CanTake
    {
        get
        {
            return canTake;
        }
    }
    [SerializeField] private bool canInteract;
    public bool CanInteract
    {
        get
        {
            return canInteract;
        }
    }
    [SerializeField] private string requiredItem;
    public string RequiredItem{
        get
        {
            return requiredItem;
        }
    }

    private Inventory inventory;

    public void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    
    public void UseItem()
    {
        inventory.ActiveItem=this.itemName;
        Debug.Log("Holding item changed");
    }

}
