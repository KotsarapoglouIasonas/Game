using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DigitalDisplay : MonoBehaviour
{
    [SerializeField] private Sprite[] digits;
    [SerializeField] private Image [] characters;
    private string codeSequense;
    [SerializeField] private string success;

    void Start()
    {
        codeSequense="";
        for (int i=0; i<characters.Length; i++)
        {
            characters[i].sprite = digits[10];
        }
        ButtonClicked.ButtonPressed += AddDigitToCodeSequence;
    }

    public void AddDigitToCodeSequence(string digitEntered)
    {
        if (codeSequense.Length<3)
        {
            switch (digitEntered)
            {
                case "zero" :
                    codeSequense += "0";
                    DisplayCodeSequence(0);
                    break;
                case "one" :
                    codeSequense += "1";
                    DisplayCodeSequence(1);
                    break;
                case "two" :
                    codeSequense += "2";
                    DisplayCodeSequence(2);
                    break;
                case "three" :
                    codeSequense += "3";
                    DisplayCodeSequence(3);
                    break;
                case "four" :
                    codeSequense += "4";
                    DisplayCodeSequence(4);
                    break;
                case "five" :
                    codeSequense += "5";
                    DisplayCodeSequence(5);
                    break;
                case "six" :
                    codeSequense += "6";
                    DisplayCodeSequence(6);
                    break;
                case "seven" :
                    codeSequense += "7";
                    DisplayCodeSequence(7);
                    break;
                case "eight" :
                    codeSequense += "8";
                    DisplayCodeSequence(8);
                    break;
                case "nine" :
                    codeSequense += "9";
                    DisplayCodeSequence(9);
                    break; 
            }
        }
      /*  switch (digitEntered)
        {
            //delete 
        } */
        
        if (codeSequense.Length==3)
        {
            if ( characters[0]!=digits[10] )
            {
                if ( characters[1]!=digits[10] )
                {
                    if ( characters[2]!= digits[10])
                    {
                        CheckResults();
                    }
                }
            }

        }
    }

    public void DisplayCodeSequence(int digitJustEntered)
    {
        switch (codeSequense.Length)
        {
            case 1:
                characters[0].sprite = digits[10];
                characters[1].sprite = digits[10];
                characters[2].sprite = digits[digitJustEntered];
                Debug.Log(codeSequense.Length);
                break;
            case 2:
                characters[0].sprite = digits[10];
                characters[1].sprite = characters[2].sprite;
                characters[2].sprite = digits[digitJustEntered];
                Debug.Log(codeSequense.Length);
                break;
            case 3:
                characters[0].sprite=characters[1].sprite;
                characters[1].sprite=characters[2].sprite;
                characters[2].sprite=digits[digitJustEntered];
                Debug.Log(codeSequense.Length);
                break;
        }
    }

    public void CheckResults()
    {
        if (codeSequense == success)
        {
            Debug.Log("Congrats! Correct Password");
        }
        else
        {
            Debug.Log("Password Incorrect! Try again!");
            ResetDisplay();
        }
    }
    public void ResetDisplay()
    {
        for (int i=0; i<characters.Length; i++)
        {
            characters[i].sprite=digits[10];
        }
        codeSequense="";
    }
    public void OnDestroy()
    {
        ButtonClicked.ButtonPressed -= AddDigitToCodeSequence;
    }


}
