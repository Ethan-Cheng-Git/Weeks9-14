using UnityEngine;

public class BarrelMove : MonoBehaviour
{
    //declare variables for the barrels
    public float speed = 10f;
    public float leftEdge = -15f;
    public float rightEdge = 18f;

    //hook the other scripts info into this script
    public PlayerInputHandle player;
    public BarrelHitBox barrelHitBox;
    public PlayerHitBox playerHitBox;

    void Update()
    {
        // the barrels move left towards the player 
        transform.position += Vector3.left * speed * Time.deltaTime;
        //if barrels go off screen, then it appears on the right side 
        if (transform.position.x < leftEdge)
        {
            transform.position = new Vector3(rightEdge, transform.position.y, transform.position.z);
        }

        //the position of the player and the barrel hit boxes
        Vector2 playerPos = playerHitBox.transform.position;
        Vector2 barrelPos = barrelHitBox.transform.position;

        //the x and y coordinate of the player and barrel
        float dx = playerPos.x - barrelPos.x;
        float dy = playerPos.y - barrelPos.y;

        //create and calculate the radius squared to determine position of both hitboxes 
        float distSquared = (dx * dx) + (dy * dy);
        float radiusSum = playerHitBox.radius + barrelHitBox.radius;
        float radiusSquared = radiusSum * radiusSum;

        //if the barrels interacts with player, the "StartDisable()" method is called in the main input script
        if (distSquared < radiusSquared)
        {
            player.StartDisable();
        }
    }
}
