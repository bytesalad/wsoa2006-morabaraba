using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    [SerializeField] private int unplacedTokensP1 = 9; //default value of 9
    [SerializeField] private int unplacedTokensP2 = 9;
    [SerializeField] private int usableTokensP1 = 9;
    [SerializeField] private int usableTokensP2 = 9;

    [SerializeField] private GameManager_StageControl stageControl;
    [SerializeField] private GameManager_TurnControl turnControl;
    [SerializeField] private Board board;

    private bool canRemoveToken = false;

    public void ClickNode(Node nodeRef)
    {
        if (stageControl.GetStage() == 1)
        {
            if (!canRemoveToken)
            {
                if (nodeRef.GetComponent<Node>().playerSet == PLAYER.NOPLAYER)
                {
                    if ((turnControl.GetTurn() == 0) && (unplacedTokensP1 > 0))
                    {
                        unplacedTokensP1--;
                        nodeRef.GetComponent<Node_Colour>().SetPlayer1();
                        nodeRef.playerSet = PLAYER.PLAYER1;
                        board.Check3P1();
                        if (!canRemoveToken)
                        {
                            turnControl.SwitchTurns();
                        }
                    }
                    else if ((turnControl.GetTurn() == 1) && (unplacedTokensP2 > 0))
                    {
                        unplacedTokensP2--;
                        nodeRef.GetComponent<Node_Colour>().SetPlayer2();
                        nodeRef.playerSet = PLAYER.PLAYER2;
                        board.Check3P2();
                        if (!canRemoveToken)
                        {
                            turnControl.SwitchTurns();
                        }
                    }
                }
            }
            else
            {
                if (turnControl.GetTurn() == 0)
                {
                    if (nodeRef.playerSet == PLAYER.PLAYER2)
                    {
                        nodeRef.playerSet = PLAYER.NOPLAYER;
                        nodeRef.GetComponent<Node_Colour>().SetNoPlayer();
                        canRemoveToken = false;
                        turnControl.SwitchTurns();
                    }
                }
                else if (turnControl.GetTurn() == 1)
                {
                    if (nodeRef.playerSet == PLAYER.PLAYER1)
                    {
                        nodeRef.playerSet = PLAYER.NOPLAYER;
                        nodeRef.GetComponent<Node_Colour>().SetNoPlayer();
                        canRemoveToken = false;
                        turnControl.SwitchTurns();
                    }
                }
            }

        }
        else if (stageControl.GetStage() == 2)
        {
            //move tokens to adjacent open spaces using NWES checking
        }
    }

    public int GetUnplacedTokensP1()
    {
        return unplacedTokensP1;
    }

    public int GetUnplacedTokensP2()
    {
        return unplacedTokensP2;
    }
}
