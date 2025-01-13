using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class Brightness : MonoBehaviour
{
    public Light Light;
    int num = 0;

    private void OnEnable()
    {
        ActionsForUnputs.Sprint += Bright;
    }

    private void OnDisable()
    {
        ActionsForUnputs.Sprint -= Bright;
    }

    void Bright()
    {
        num++;

        if (num%2 == 1)
        {
            Light.intensity = Light.intensity * 0.5f;
        }
        else
        {
            Light.intensity = Light.intensity * 2.0f;
        }
    }
}
