using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    private GameObject [] items = GameObject.FindObjectsOfType<GameObject>();
    public GameObject [] Items
    {
        get
        {
            return items;
        }
    }
    [SerializeField] private string scenename;
    public string Scenename
    {
        get
        {
            return scenename;
        }
    }

}
