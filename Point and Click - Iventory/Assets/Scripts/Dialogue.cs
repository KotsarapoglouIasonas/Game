using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    [SerializeField] private string objectName;
    public string ObjectName
    {
        get
        {
            return objectName;
        }
    }
    [TextArea(3,10)]
    [SerializeField] private string[] sentences;
    [SerializeField] private Sprite[] portraits; 
    public string[] Sentences
    {
        get
        {
            return sentences;
        }
    }

}
