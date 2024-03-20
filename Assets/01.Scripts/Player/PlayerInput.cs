using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Action OnJumpEvent;

    private void Update() 
    {
        JumpInput();
    }

    private void JumpInput()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            OnJumpEvent?.Invoke();
        }
    }
}
