using UnityEngine;

public class CrouchingState : MovementBaseState
{
    public override void EnterState(MovementStateManager movement)
    {
        movement.anim.SetBool("Crouching", true); // Optional: only if you have crouch idle or crouch blend tree
    }

    public override void UpdateState(MovementStateManager movement)
    {
        movement.moveSpeed = movement.VInput < 0 ? movement.crouchBackSpeed : movement.crouchSpeed;
    }

    public override void ExitState(MovementStateManager movement)
    {
        movement.anim.SetBool("Crouching", false);
    }
}