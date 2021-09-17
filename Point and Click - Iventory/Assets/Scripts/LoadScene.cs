using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    private GameObject scene;
    [SerializeField] private Button[] buttons;

    void Start()
    {   
        scene = GetComponent<GameObject>();
    }

    public void LoadingSceneOne(){
        if (buttons[0].interactable == true)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void LoadingSceneTwo()
    {
        if (buttons[1].interactable == true)
        {
            SceneManager.LoadScene("omg");
        }
    }

}
