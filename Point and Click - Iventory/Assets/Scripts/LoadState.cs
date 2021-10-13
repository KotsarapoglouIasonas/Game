using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class LoadState : ScriptableObject
{
    [SerializeField] private GameObject [] gameobjects = GameObject.FindObjectsOfType<GameObject>();
    [SerializeField] private bool [] states;

    public void SaveStates()
    {
        states=new bool[gameobjects.Length];
        for (int i=0; i<gameobjects.Length; i++)
        {
            if ( gameobjects[i].gameObject.activeSelf==true)
            {
                states[i]=true;
            }
            else
            {
                states[i]=false;
            }
        }
    }

    public void LoadStates()
    {
        for (int i=0; i<gameobjects.Length; i++)
        {
            gameobjects[i].gameObject.SetActive(states[i]);
        }

    }

}
