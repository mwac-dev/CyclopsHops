using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    private bool _isHolding;
    private void OnEnable()
    {
        //InputManager.Instance.EnableActionMap("Movement");
        InputManager.Instance.Input.Movement.TouchHold.performed += OnTouchHold;
        InputManager.Instance.Input.Movement.TouchTap.performed += OnTouchTap;
        InputManager.Instance.Input.Movement.TouchPosition.performed += OnTouchPos;

    }

    private void OnTouchTap(InputAction.CallbackContext obj)
    {
        Debug.Log("TAP");
    }

    private void OnTouchPos(InputAction.CallbackContext obj)
    {
        Debug.Log("POS = " + obj.ReadValue<Vector2>());

        if (_isHolding)
        {
            Debug.Log("DRAGGING");
        }
        
    }

    private void OnTouchHold(InputAction.CallbackContext obj)
    {
        Debug.Log("HOLD");
        if(obj.performed)
        {
            _isHolding = true;
        }
        else if(obj.canceled)
        {
            _isHolding = false;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
