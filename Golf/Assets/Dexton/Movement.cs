using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(Rigidbody2D))] // THIS SCRIPT REQUIRES A RIGID BODY AND WILL ADD ONE IF THEY DONT 

public class Movement : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D _rb;
    private Vector2 _moveAmount;

    void Awake()
    {
        // grabs the rigid for the rigid body for player
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rb.linearVelocityX = _moveAmount.x * movementSpeed;
        _rb.linearVelocityY = _moveAmount.y * movementSpeed;
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
        _moveAmount = (ctx.ReadValue<Vector2>());
    }



}
