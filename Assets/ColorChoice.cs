using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChoice : MonoBehaviour
{
    public Dropdown PlayerColorDropdown;
    public static string PlayerColor;

    public Text MyChoice;

    public void SetColor()
    {
        switch (PlayerColorDropdown.value)
        {
            case 1:
                PlayerColor = "Black";
                MyChoice.text = "Black";
                break;
            case 2:
                PlayerColor = "Blue";
                MyChoice.text = "Blue";
                break;
            case 3:
                PlayerColor = "Red";
                MyChoice.text = "Red";
                break;
         

            default:
                MyChoice.text = "Please Select";
                break;
        }
    }
}
