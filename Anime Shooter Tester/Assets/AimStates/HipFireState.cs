﻿using UnityEngine;

public class HipFireState : AimBaseState
{
    public override void EnterState(AimStateManager aim)
    {
        Debug.Log("Entered Hip Fire State");
        aim.anim.SetBool("isAiming", false);
        aim.currentFov = aim.hipFov; // ✅ Switch back to hip FOV
    }

    public override void UpdateState(AimStateManager aim)
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            aim.SwitchState(aim.Aim);
        }
    }

    public override void ExitState(AimStateManager aim)
    {
        // Nothing needed here for now
    }
}