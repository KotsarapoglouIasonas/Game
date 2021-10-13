using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : NewItems
{
    private DigitalDisplay display;

    public override void Awake()
    {
        display=FindObjectOfType<DigitalDisplay>();
    }

    public override void Interaction(){
        display.StartLock();
    }
    public override void UseItem()
    {
        inventory.ActiveItem=this.itemName;
        Debug.Log("Holding item changed");
    }
}
