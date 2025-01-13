using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static GameInput;

public class PlayerInput : MonoBehaviour, GameInput.IGameInputsActions
{
    private GameInput gameInput;

    void Awake()
    {
        gameInput = new GameInput();
        // Enable the input system
        gameInput.GameInputs.SetCallbacks(this);

        gameInput.GameInputs.Enable();
    }

    #region

    private Action InteractEvent;

    #endregion

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            InteractEvent?.Invoke();
            Debug.Log("test");
            ActionsForUnputs.Interact.Invoke();
        }
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        gameInput.GameInputs.Enable();
    }
}
