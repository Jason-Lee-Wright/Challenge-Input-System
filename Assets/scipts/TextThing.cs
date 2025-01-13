using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextThing : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;

    private int times = 0;

    private void OnEnable()
    {
        ActionsForUnputs.Jump += Text;
    }

    private void OnDisable()
    {
        ActionsForUnputs.Jump -= Text;
    }

    void Text()
    {
        times++;

        if (times%2 == 1)
        {
            textMeshProUGUI.text = "Hello";
        }
        else
        {
            textMeshProUGUI.text = "Goodbye";
        }
    }
}
