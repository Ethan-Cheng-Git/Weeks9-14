using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    //declare and gather the jumping variables as well as condition to check if player is on ground
    public float jumpingHeight = 5f;
    public float jumpingSpeed = 6f;
    public float fallSpeed = 2f;
    public bool isGround = true;

    public float startY = 0;
    public float tarY;
    void Start()
    {
        //the target of the y coordinate is the jump height
        tarY = jumpingHeight;
    }

    // Update is called once per frame
    void Update()
    {
        //if the player is not on the ground, the player falls 
        if (!isGround)
        {
            //player falls
            transform.position += Vector3.down * fallSpeed * Time.deltaTime;
            //player stops falling on the y coordinate (ground) the player is running on 
            if (transform.position.y <= 0)
            {
                transform.position = new Vector3(transform.position.x,0f, transform.position.x);
                isGround = true;
            }
        }
    }

    //method for the player to jump
    public void Jump()
    {
        //if the player is on the ground, the player is able to jump
        if (isGround)
        {
            transform.position += Vector3.up * jumpingHeight;
            isGround = false;
        }
    }
}
