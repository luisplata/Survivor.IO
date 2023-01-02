using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : InputCustom
{
    [SerializeField] private bool isPhone;
    [SerializeField] private Joystick joystick;
    private Vector2 direction;

    private void Start()
    {
        //ask if is a Phones or not
        isPhone = true;
    }

    public void MovePlayer(InputAction.CallbackContext call)
    {
        direction = call.ReadValue<Vector2>();
    }
    
    public override Vector2 Direction => isPhone ? joystick.Direction : direction;
}