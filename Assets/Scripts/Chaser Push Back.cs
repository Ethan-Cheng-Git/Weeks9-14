using UnityEngine;
using UnityEngine.InputSystem;
public class ChaserPushBack : MonoBehaviour
{
    //declare variables for wall values 
    public float pushBackValue = 1f;
    public float chasingValue = 2f;

    public float leftEdge = -11f;
    public float rightReset = 5;
    void Update()
    {
        //the wall moves right
        transform.position += Vector3.right * chasingValue * (Time.deltaTime * 2);
        //if the wall touches the position of the player, it restarts
        if (transform.position.x >= rightReset)
        {
            transform.position = new Vector3(leftEdge, transform.position.y, transform.position.z);
        }
    }
    //a method for the pushback mechanic 
    public void PushItBack()
    {
        transform.position -= Vector3.right * pushBackValue;

        //player cannot pushback the wall past the left edge value 
        if (transform.position.x < leftEdge)
        {
            transform.position = new Vector3(leftEdge, transform.position.y, transform.position.z);
        }
    }
}
