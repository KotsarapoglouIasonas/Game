using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {


    private Inventory inventory;
    [SerializeField] private int index;
    public int Index
    {
        get
        {
            return index;
        }
    }

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <= 0) 
        {
            inventory.isFull[index]=false;
        }
    }

    public void Cross() 
    {

        foreach (Transform child in transform) 
        {
            child.GetComponent<Spawn>().SpawnItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
