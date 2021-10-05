using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveScene
{
    public static void SaveState(List <string> _items,bool [] _itemsState,List <string>  _carItems)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/scene.state";
        FileStream stream = new FileStream(path, FileMode.Create);
        SceneState state = new SceneState(_items,_itemsState,_carItems);
        formatter.Serialize(stream , state);
        stream.Close();
    }

    public static SceneState LoadState()
    {
        string path = Application.persistentDataPath + "/scene.state";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            

            SceneState state = formatter.Deserialize(stream) as SceneState;
            stream.Close();
            return state;
        }
        else
        {
            Debug.LogError("Save file already exists!");
            return null;
        }
    }
}
