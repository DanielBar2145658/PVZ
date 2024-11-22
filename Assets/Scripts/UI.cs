using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text Money;
    public TMP_Text Insanity;

    public void UpdateText() 
    {
        Money.text = "Sun: " + Gamemanager.Instance.Sun;

        Insanity.text = "Insanity: " + Gamemanager.Instance.Insanity;
    
    }




}
