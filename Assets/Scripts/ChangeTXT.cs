using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ChangeTXT : MonoBehaviour
{
    public TMP_Text text;
    //public GlobalShit GlobalShit;
    public Value value;


    private void Update()
    {
        //Change text 
        text.text = value.Valor.ToString();
    }
}
