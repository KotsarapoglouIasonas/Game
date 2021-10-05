using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SceneState
{
    public string [] items;
    public bool [] itemsState;
    public string [] carItems;

    public SceneState(List <string> _items, bool [] _itemsState, List <string>  _carItems)
    {
        items = new string[_items.Count];
        for (int i=0; i<_items.Count; i++)
        {
            items[i]=_items[i];
        }

        for (int i=0; i<_itemsState.Length; i++)
        {
            itemsState[i]=_itemsState[i];
        }
        carItems = new string[_carItems.Count];
        for (int i=0; i<_carItems.Count; i++)
        {
            carItems[i]=_carItems[i];
        }
    }
}
