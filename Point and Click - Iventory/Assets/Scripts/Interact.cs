using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private Inventory inventory;
    private NewItems effect;


    private void Awake()
    {
        effect=GetComponent<NewItems>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnMouseDown(){
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
