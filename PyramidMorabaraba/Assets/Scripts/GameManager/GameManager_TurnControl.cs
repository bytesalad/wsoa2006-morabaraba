using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_TurnControl : MonoBehaviour
{
    [SerializeField] private bool turn;
    //0 = player 1
    //1 = player 2

    public void SwitchTurns()
    {
        if (turn)
        {
            turn = false;
        }
        else
        {
            turn = true;
        }
    }

    public bool GetTurn()
    {
        return turn;
    }
}
