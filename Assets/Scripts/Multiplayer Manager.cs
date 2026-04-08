using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MultiplayerManager : MonoBehaviour
{
    public List<Sprite> playerSprites;
    public List<PlayerInput> players;

    public void OnPlayerJoin(PlayerInput player)
    {
        players.Add(player);

        SpriteRenderer sr = player.GetComponent<SpriteRenderer>();
        sr.sprite = playerSprites[player.playerIndex];

        Multiplayer controller = player.GetComponent<Multiplayer>();
        controller.manager = this;
    }

    public void PlayerAttacking(PlayerInput attackingPlayer)
    {
        for (int i = 0; i < players.Count; i++)
        {
            if (attackingPlayer == players[i]) continue;

            if (Vector2.Distance(attackingPlayer.transform.position, players[i].transform.position) < 0.5f)
            {
                Debug.Log("Player " + attackingPlayer.playerIndex + " hit player " + players[i].playerIndex);
            }
        }
    }
}
