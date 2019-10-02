using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_TurnControl : MonoBehaviour
{
    [SerializeField] private int turn = 0;
    //0 = player 1
    //1 = player 2

    public void SwitchTurns()
    {
        if (turn == 0)
        {
            turn = 1;
        }
        else
        {
            turn = 0;
        }
    }

    public int GetTurn()
    {
        return turn;
    }
}
