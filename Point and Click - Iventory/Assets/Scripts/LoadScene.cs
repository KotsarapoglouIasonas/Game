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


    public void LoadScenes(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }


    public void AddScene(string scene)
    {
        availableScenes.Add(scene);
    }

}
