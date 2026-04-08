using UnityEngine;

public class FirewallCollision : MonoBehaviour
{
    //call the other scripts and create the objects 
    public PlayerInputHandle player;
    public WallHitBox wallHitBox;
    public PlayerHitBox playerHitBox;
    
    void Update()
    { 
        //gather the wall and player positions
        Vector2 playerPos = playerHitBox.transform.position;
        Vector2 wallPos = wallHitBox.transform.position;

        //the x and y coordinate of the player and wall
        float dx = playerPos.x - wallPos.x;
        float dy = playerPos.y - wallPos.y;

        //create and calculate the radius squared to determine position of both hitboxes 
        float distSquared = (dx * dx) + (dy * dy);
        float radiusSum = playerHitBox.radius + wallHitBox.radius;
        float radiusSquared = radiusSum * radiusSum;

        //if the wall interacts with player, the "StartDisable()" method is called in the main input script
        if (distSquared < radiusSquared)
        {
            player.playerIsCaught.Invoke();
        }
    }
}
