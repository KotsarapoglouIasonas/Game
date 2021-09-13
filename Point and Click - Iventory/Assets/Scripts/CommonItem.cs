using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonItem : NewItems
{
    public override void  Interaction(){
        if (requiredItem=="")
        {
            Debug.Log("Positive");
        }
    }
}
