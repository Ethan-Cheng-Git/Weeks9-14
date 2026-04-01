using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class TilemapStuff : MonoBehaviour
{
    public Tilemap tilemap;
    public Transform banana;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3Int cellPos = tilemap.WorldToCell(mousePos);
        Vector3 pos = tilemap.GetCellCenterWorld(cellPos);
        ////Debug.Log(mousePos + " is at cell: " + cellPos);
        banana.position = pos;
    }
}
