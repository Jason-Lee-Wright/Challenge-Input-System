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

    private Action JumpEvent;

    private Action SprintEvent;

    #endregion

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            InteractEvent?.Invoke();
            ActionsForUnputs.Interact.Invoke();
        }
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            JumpEvent?.Invoke();
            ActionsForUnputs.Jump.Invoke();
        }
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            SprintEvent?.Invoke();
            ActionsForUnputs.Sprint.Invoke();
        }
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        gameInput.GameInputs.Enable();
    }
}
