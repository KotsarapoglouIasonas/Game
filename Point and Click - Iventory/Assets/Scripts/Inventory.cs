using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    private Dictionary <int ,NewItems> items = new Dictionary<int ,NewItems>() ;
    public Dictionary <int ,NewItems >Items
    {
        get
        {
            return items;
        }
    }
    private Dictionary <string ,string> keys = new Dictionary<string ,string>();
    public Dictionary <string, string> Keys
    {
        get
        {
            return keys;
        }
    }
    [SerializeField] private List <Dialogue> Dialogues;
    [SerializeField] private string activeItem;
    public string ActiveItem
    {
        get
        {
            return activeItem;
        }
        set
        {
            activeItem=value;
        }
    }
    [SerializeField] private List <string>  CarItems;
    public List <string> CarrItems
    {
        get
        {
            return CarItems;
        }
    }
    [SerializeField] private List <GameObject> SceneCarItems;
    public Slot [] slots;
    public bool [] isFull; 

    void Start()
    {
        for (int i=0; i<SceneCarItems.Count; i++)
        {
            SceneCarItems[i].SetActive(false);
        }
        for (int i=0; i<CarItems.Count; i++)
        {
            for (int j=0; j<SceneCarItems.Count; j++)
            {
                if (CarItems[i] == SceneCarItems[i].name)
                {
                    //SceneCarItems[i].SetActive(true);
                }
            }
        }
        keys.Add("aioliki-book","ΚΙΜΙΝΤΕΝΙΑ");
        keys.Add("galini-book","ΑΝΑΒΥΣΣΟΣ");
        keys.Add("slingshot","ΚΙΤΡΙΝΟ");
    }



    public void addItem(int i,NewItems obj)
    {
        if (items.ContainsKey(i))
        {
            items.Remove(i);
        }
        items.Add(i,obj);
    }

    public int nextAvailable()
    {
        for (int i=0; i<slots.Length; i++)
        {
            if (slots[i].Index==0)
            {
                return i;
            }
        }
        return 5;
    }

    public void AddToCar(string obj)
    {
        CarItems.Add(obj);
    }

    public void AddDialogue(Dialogue dialogue)
    {
        if (Dialogues.Contains(dialogue))
        {
            Debug.Log("This diaologue already exist in recording list!");
        }
        else
        {
            Dialogues.Add(dialogue);
        }
    }




}
