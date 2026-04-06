using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputHandle : MonoBehaviour
{
    public ChaserPushBack chase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPushItBack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            chase.PushItBack();
        }
       
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            chase.Jump();
        }

    }

}
