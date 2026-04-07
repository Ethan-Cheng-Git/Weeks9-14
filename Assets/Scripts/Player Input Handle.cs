using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
public class PlayerInputHandle : MonoBehaviour
{
    Coroutine disable;
    public ChaserPushBack chase;
    public PlayerJump jump;
    public bool canPushItBack = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPushItBack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed && canPushItBack)
        {
            chase.PushItBack();
        }
       
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            jump.Jump();
        }

    }

    public void StartDisable()
    {
        if (disable != null)
        {
            StopCoroutine(disable);
        }
        disable = StartCoroutine(DisableThePushBack());
    }

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
