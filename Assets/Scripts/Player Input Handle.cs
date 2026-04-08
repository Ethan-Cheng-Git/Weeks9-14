using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.Events;
public class PlayerInputHandle : MonoBehaviour
{
    //set up all the variables and set up info for other scripts to accsess
    Coroutine disable;
    public ChaserPushBack chase;
    public PlayerJump jump;
    public bool canPushItBack = true;
    public UnityEvent playerIsCaught;

    //with input, calls the pushback mechanic to be performed 
    public void OnPushItBack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed && canPushItBack)
        {
            chase.PushItBack();
        }
       
    }
    //with input, calls the jump mechanic to be performed
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            jump.Jump();
        }

    }

    //method sets up disable mechanic if the player touches a barrel in which the method is called in the Barrel Move script
    public void StartDisable()
    {
        if (disable != null)
        {
            StopCoroutine(disable);
        }
        disable = StartCoroutine(DisableThePushBack());
    }

    //adds the coroutine to disable the pushback
    IEnumerator DisableThePushBack()
    {
        canPushItBack = false;
        float t = 0;
        while (t < 0.5f) 
        {
            t += Time.deltaTime;
            yield return null;
        }
        canPushItBack = true;
    }

}
