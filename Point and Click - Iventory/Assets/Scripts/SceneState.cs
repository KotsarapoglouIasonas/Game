using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SceneState
{
    public string [] items;
    public bool [] itemsState;
    public string namescene;


    public SceneState(string [] _items, bool [] _itemsState,string name)
    {
        items = new string[_items.Length];
        for (int i=0; i<_items.Length; i++)
        {
            items[i]=_items[i];
        }

        for (int i=0; i<_itemsState.Length; i++)
        {
            itemsState[i]=_itemsState[i];
        }
        namescene = name;
    }
}
