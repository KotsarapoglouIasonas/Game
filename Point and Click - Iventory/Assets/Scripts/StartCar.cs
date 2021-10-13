using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class StartCar : MonoBehaviour
{   
    [SerializeField] private GameObject miniMap;
    [SerializeField] private GameObject fullMap;
    private GameObject newScene;
    private LoadScene loadscene;
    [SerializeField] private Scenes[] scene;
    //[SerializeField] private LoadState loadState;

    void Start()
    {
        for (int i=0; i<scene.Length; i++)
        {
            scene[i].Pic.gameObject.SetActive(false);
        }
        loadscene=FindObjectOfType<LoadScene>();
        miniMap.gameObject.SetActive(false);
        fullMap.gameObject.SetActive(false);

    }

    public void ShowMiniMap()
    {
        miniMap.gameObject.SetActive(true);
    }

    public void ShowMap()
    {
        for (int i=0; i<scene.Length; i++)
        {
            if (loadscene.AvailableScenes.Contains(scene[i].PicName))
            {
                scene[i].Pic.gameObject.SetActive(true);
            }
            /*newScene = Instantiate(loadscene.PrefabScene,fullMap.transform,false);
            newScene.GetComponent<Text>().text=(loadscene.AvailableScenes[i]);
            string scene = loadscene.AvailableScenes[i];
            newScene.GetComponent<Button>().onClick.AddListener(delegate{TaskOnClick(scene);});
            Debug.Log("Prefab added");*/
        }
        fullMap.gameObject.SetActive(true);
    }

    public void TaskOnClick(string scene){
        loadscene.LoadScenes(scene);
    }
}
