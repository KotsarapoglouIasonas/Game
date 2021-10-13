using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    [SerializeField] private string Picname;
    public string PicName
    {
        get
        {
            return  Picname;
        }
    }
    [SerializeField] private GameObject pic;
    public GameObject Pic
    {
        get
        {
            return pic;
        }
    }
    private StartCar car;

    void Awake()
    {
        car=FindObjectOfType<StartCar>();
    }

    public void sceneLoad()
    {
        car.TaskOnClick(Picname);
    }

}
