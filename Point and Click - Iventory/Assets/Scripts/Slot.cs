using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {


    private Inventory inventory;
    private int index;
    public int Index{
        get
        {
            return index;
        }
    }
    private NewItems slotItem;

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    /*private void Update()
    {
        if (transform.childCount <= 0) {
            inventory.items[index] = 0;
        }
    }*/
    /*public void addItem(NewItems x){
        slotItem=x;
    }*/

    public void Cross() {

        foreach (Transform child in transform) {
            child.GetComponent<Spawn>().SpawnItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
