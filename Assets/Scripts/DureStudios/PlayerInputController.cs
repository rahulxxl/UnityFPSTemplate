using UnityEngine;
using UnityEngine.InputSystem;

namespace DureStudios
{
public class PlayerInputController : MonoBehaviour
{
    [Header("Character Input Values")] public Vector2 move;
    public Vector2 look;
    public bool jump;
    public bool sprint;
    public bool crouched;


    [Header("Movement Settings")] public bool analogMovement;
    [Header("Mouse Cursor Settings")] public bool cursorLocked = true;
    public bool cursorInputForLook = true;


#region Messages from PlayerInput Component

    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void OnLook(InputValue value)
    {
        if (cursorInputForLook) {
            LookInput(value.Get<Vector2>());
        }
    }

    public void OnJump(InputValue value)
    {
        JumpInput(value.isPressed);
    }

    public void OnCrouch(InputValue value)
    {
        CrouchInput(value.isPressed);
    }

    public void OnInteract(InputValue value)
    {
        InteractInput(value.isPressed);
    }

    public void OnUse(InputValue value)
    {
        UseInput(value.isPressed);
    }

    public void OnDrop(InputValue value)
    {
        DropInput(value.isPressed);
    }

    public void OnSprint(InputValue value)
    {
        SprintInput(value.isPressed);
    }

#endregion

    /*
    public void ResetCrouch()
    {
        crouched = false;
    }
    */

    private void MoveInput(Vector2 newMoveDirection)
    {
        move = newMoveDirection;
        // Debug.Log("Moving Character");
    }

    private void LookInput(Vector2 newLookDirection)
    {
        look = newLookDirection;
        // Debug.Log("Looking Around");
    }

    public void JumpInput(bool newJumpState)
    {
        jump = newJumpState;
        // Debug.Log("Jumping Character");
    }

    private void CrouchInput(bool newCrouchState)
    {
        crouched = !crouched;
    }

    private void InteractInput(bool newInteractState)
    {
        Debug.Log("interacted");
    }

    private void UseInput(bool newUseState)
    {
        Debug.Log("Used the Item");
    }

    private void DropInput(bool newDropState)
    {
        Debug.Log("Dropped the Item");
    }

    private void SprintInput(bool newSprintState)
    {
        sprint = newSprintState;
        // Debug.Log("Sprinting");
    }


    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }

    /*
    public void OnControlsChanged()
    {

    }
    */
}
}