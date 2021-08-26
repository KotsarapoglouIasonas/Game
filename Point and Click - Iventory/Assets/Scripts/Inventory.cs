using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    private Dictionary <string ,NewItems> items = new Dictionary<string ,NewItems>() ;
    public Dictionary <string ,NewItems >Items{
        get
        {
            return items;
        }
    }
    private int limit = 4;
    public int Limit{
        get
        {
            return limit;
        }
        set
        {
            limit = value;
        }
    }
    public GameObject [] slots;

   // public void Awake(){
   //     slots=GetComponentInChildren<Slot>();
    //}

}
