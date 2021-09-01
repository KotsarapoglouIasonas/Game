using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    
    [SerializeField] private GameObject item;


    public void SpawnItem() {
        Instantiate(item, transform.position, transform.rotation);
    }
}
