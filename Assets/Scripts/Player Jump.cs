using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpingHeight = 5f;
    public float jumpingSpeed = 6f;
    public float fallSpeed = 2f;
    public bool isGround = true;

    public float startY = 0;
    public float tarY;
    void Start()
    {
        tarY = jumpingHeight;
    }

    // Update is called once per frame
    void Update()
    {

        if (!isGround)
        {
            transform.position += Vector3.down * fallSpeed * Time.deltaTime;
            if (transform.position.y <= 0)
            {
                transform.position = new Vector3(transform.position.x,0f, transform.position.x);
                isGround = true;
            }
        }
    }

    public void Jump()
    {
        if (isGround)
        {
            transform.position += Vector3.up * jumpingHeight;
            isGround = false;
        }
    }
}
