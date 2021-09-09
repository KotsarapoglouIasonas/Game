using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonClicked : MonoBehaviour
{
    public static event Action<string> ButtonPressed = delegate { };
    [SerializeField] private string buttonName;
    private string buttonValue;
    private int deviderPosition;

    void Start()
    {
        buttonName=gameObject.name;
        deviderPosition=buttonName.IndexOf("_");
        buttonValue=buttonName.Substring(0,deviderPosition);
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonPushed);
    }

    public void ButtonPushed()
    {
        ButtonPressed(buttonValue);
    }
}
