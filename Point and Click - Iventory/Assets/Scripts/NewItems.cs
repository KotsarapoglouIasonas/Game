using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NewItems : MonoBehaviour
{
    [SerializeField] protected string itemName;
    public string ItemName
    {
        get
        {
            return itemName;
        }
    }
    [SerializeField] protected Sprite inventoryImage;
    public Sprite InventoryImage
    {
        get
        {
            return inventoryImage;
        }
    }
    [SerializeField] protected Sprite worldImage;
    [SerializeField] protected bool canTake;
    public bool CanTake
    {
        get
        {
            return canTake;
        }
    }
    [SerializeField] protected bool canInteract;
    public bool CanInteract
    {
        get
        {
            return canInteract;
        }
    }
    [SerializeField] protected string requiredItem;
    public string RequiredItem{
        get
        {
            return requiredItem;
        }
    }

    protected Inventory inventory;

    public virtual void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    
    public abstract void UseItem();

    public abstract void Interaction();

}
