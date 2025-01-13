using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    private void OnEnable()
    {
        ActionsForUnputs.Interact += Move;
    }

    private void Move()
    {
        Debug.Log("Working");
        transform.position = transform.position * -1;
    }
}
