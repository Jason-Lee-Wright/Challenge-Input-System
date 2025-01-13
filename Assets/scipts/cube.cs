using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    private void OnEnable()
    {
        ActionsForUnputs.Interact += Move;
    }

    private void OnDisable()
    {
        ActionsForUnputs.Interact -= Move;
    }

    private void Move()
    {
        transform.position = transform.position * -1;
    }
}
