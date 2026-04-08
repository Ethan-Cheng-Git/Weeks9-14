using UnityEngine;

public class Restart : MonoBehaviour
{
    //gathers the position and number of barrels
    public Transform wall;
    public Vector2 wallBeginPos;

    public Transform[] barrels;
    public Vector2[] barrelBeginPos;

    public PlayerInputHandle player;
    void Start()
    {
        //brings in the wall position with the beginning wall position
        wallBeginPos = wall.position;
        barrelBeginPos = new Vector2[barrels.Length];
        //counts all the barrels numbers and sets up the barrels
        for (int i =  0; i < barrels.Length; i++)
        {
            barrelBeginPos[i] = barrels[i].position;
        }

    }

    //method to restart the positions of the wall and barrels if player touches wall
    public void Restarted()
    {
        wall.position = wallBeginPos;

        for(int i = 0;i < barrels.Length;i++)
        {
            barrels[i].position = barrelBeginPos[i];
        }

        player.canPushItBack = true;
    }
}
