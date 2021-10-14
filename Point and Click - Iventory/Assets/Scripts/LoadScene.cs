using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadScene : MonoBehaviour
{
    [SerializeField] private List<string> availableScenes;
    public List<string> AvailableScenes
    {
        get
        {
            return availableScenes;
        }
    }
    [SerializeField] private GameObject prefabScene;
    public GameObject PrefabScene
    {
        get
        {
            return prefabScene;
        }
    }
    private Button btn;
    private ManagerScene manager;
    private Save save;

    void Start()
    {
        save = FindObjectOfType<Save>();
        LoadSave();
        manager = FindObjectOfType<ManagerScene>();
    }


    public void LoadScenes(string SceneName)
    {
        string[] names=new string[manager.Items.Length];
        bool[] states=new bool[manager.Items.Length];
        string sceneName = manager.Scenename;
        for (int i=0; i<manager.Items.Length; i++)
        {
            names[i] = manager.Items[i].name;
            states[i] = manager.Items[i].activeSelf;
        }
        SceneState state = new SceneState(names,states,sceneName);
        save.SaveScene(state);
        SceneManager.LoadScene(SceneName);
    }


    public void AddScene(string scene)
    {
        availableScenes.Add(scene);
    }
    public void LoadSave()
    {
       /* if (save.Scenestates.Length==0)
        {
            Debug.Log("Save doesnt exist for this scene");
        }
        else 
        {
            SceneState newstate = save.Scenestates[1];
            if (newstate.namescene == SceneManager.sceneName)
            {
                for (int i=0; i<newstate.items.Length; i++)
                {
                    for (int j=0; j<manager.Items.Length; j++)
                    {
                        if (newstate.items[i] == manager.Items[j].name)
                        {
                            manager.Items[j].activeSelf==newstate.itemsState[i];
                            break;
                        }
                    }
                }
            }

        }*/
    }

}
