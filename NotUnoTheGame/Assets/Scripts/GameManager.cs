using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Player { Player1, Player2 }
    public Player CurrentPlayer { get; private set; } = Player.Player1;
    private bool cardPlayedThisTurn = false;

    void Start()
    {

    }

    public bool CanPlayerDrag()
    {
        return !cardPlayedThisTurn && IsPlayerTurn(CurrentPlayer);
    }


    public bool IsPlayerTurn(Player player)
    {
        return CurrentPlayer == player;
    }

    public void CardPlayed()
    {
        cardPlayedThisTurn = true;
        EndTurn();
    }

    public void EndTurn()
    {
        if (CurrentPlayer == Player.Player1)
        {
            CurrentPlayer = Player.Player2;
        }
        else
        {
            CurrentPlayer = Player.Player1;
        }
        cardPlayedThisTurn = false;
        Debug.Log($"It's now {CurrentPlayer}'s turn.");
    }
}
