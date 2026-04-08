using UnityEngine;

public class Restart : MonoBehaviour
{
    public Transform wall;
    public Vector2 wallBeginPos;

    public Transform[] barrels;
    public Vector2[] barrelBeginPos;

    public PlayerInputHandle player;
    void Start()
    {
        wallBeginPos = wall.position;
        barrelBeginPos = new Vector2[barrels.Length];
        for (int i =  0; i < barrels.Length; i++)
        {
            barrelBeginPos[i] = barrels[i].position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        wall.position = wallBeginPos;

        for(int i = 0;i < barrels.Length;i++)
        {
            barrels[i].position = barrelBeginPos[i];
        }

        player.canPushItBack = true;
    }
}
