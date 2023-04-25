using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deneme2 : MonoBehaviour
{
    public   string input;
    public Text text;

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
        text.text = "Tebrikler  baþarý ile doldurdunuz";
    }
}
