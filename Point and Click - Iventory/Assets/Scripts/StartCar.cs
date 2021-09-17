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

    void Start()
    {
        miniMap.gameObject.SetActive(false);
        fullMap.gameObject.SetActive(false);
    }

    public void ShowMiniMap()
    {
        miniMap.gameObject.SetActive(true);
    }

    public void ShowMap()
    {
        fullMap.gameObject.SetActive(true);
    }
}
