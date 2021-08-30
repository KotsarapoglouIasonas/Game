using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    private Dictionary <int ,NewItems> items = new Dictionary<int ,NewItems>() ;
    public Dictionary <int ,NewItems >Items{
        get
        {
            return items;
        }
    }
    public Slot [] slots;
    public bool [] isFull; 


   public void Awake(){
        //slots=GetComponentsInChildren<Slot>();
    }

    public void addItem(int i,NewItems obj){
        if (items.ContainsKey(i)){
            items.Remove(i);
        }
        items.Add(i,obj);
    }

    public int nextAvailable(){
        for (int i=0; i<slots.Length; i++){
            if (slots[i].Index==0){
                return i;
            }
        }
        return 5;
    }




}
