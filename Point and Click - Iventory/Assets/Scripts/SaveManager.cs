using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private Inventory inventory;
    private SceneState scene;
    [SerializeField] private List<string> items;
    [SerializeField] private GameObject [] SceneObjects = GameObject.FindGameObjectsWithTag("Untagged");
    private bool[] itemsState;
    private List<string> carItems;
    private GameObject obj;

    public void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
        for (int i=0; i<SceneObjects.Length; i++)
        {
            items.Add(SceneObjects[i].name);
        }
        for (int i=0; i<items.Count; i++)
        {
            obj = GameObject.Find(items[i]);
            if (obj.activeSelf){
                itemsState[i]=true;
            }
            else
            {
                itemsState[i]=false;
            }
        }
        
        for (int i=0; i<inventory.CarrItems.Count; i++)
        {
            carItems.Add(inventory.CarrItems[i]);
        }
    }

    public void SaveStateScene()
    {
        SaveScene.SaveState(items,itemsState,carItems);
    }

    public void LoadStateScene()
    {
        SceneState state = SaveScene.LoadState();
        for (int i=0; i<scene.items.Length; i++)
        {
            scene.items[i]=state.items[i];
        }
        for (int i=0; i<scene.itemsState.Length; i++)
        {
            scene.itemsState[i]=state.itemsState[i];
        }
        for (int i=0; i<scene.carItems.Length; i++)
        {
            scene.carItems[i]=state.carItems[i];
        }
    }

}
