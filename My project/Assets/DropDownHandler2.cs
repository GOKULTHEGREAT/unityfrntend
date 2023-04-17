using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DropDownHandler2 : MonoBehaviour
{
    public Dropdown option;
    private void Start() {
            option.onValueChanged.AddListener(delegate
             {
                optionValueChangeHappened(option);
            });
        
    }
    public void optionValueChangeHappened(Dropdown sender)
    {
        Debug.Log("You have selected:"+sender.value);
        
    }
}
