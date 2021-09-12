using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Dialogue", menuName = "Dialogue")]
public class Dialogue : ScriptableObject
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
