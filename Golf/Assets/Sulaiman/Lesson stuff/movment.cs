using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements.InputSystem;

[RequireComponent(typeof(Rigidbody2D))] // this script can only be added to a gameObject with a rigidbody2D
public class movment : MonoBehaviour
{
    public float movementSpeed;
    private Rigidbody2D _rb;
    private Vector2 _moveAmount;

    void Awake()
    {
        // se the _rb variable equal to this gameobject's rigidbody.
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        _rb.linearVelocityX = _moveAmount.x * movementSpeed;
    }
    
    // handels the logic for player movement inputs
    public void HandleMovement(InputAction ctx)
    {
        _moveAmount = ctx.ReadValue<Vector2>();
    }

}
