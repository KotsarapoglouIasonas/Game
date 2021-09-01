using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    
    [SerializeField] private NewItems newitem;


    public void SpawnItem() {
        Instantiate(newitem, transform.position, transform.rotation);
    }
}
