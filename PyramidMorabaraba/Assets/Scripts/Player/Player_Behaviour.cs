using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    [SerializeField] private int unplacedTokensP1 = 9; //default value of 9
    [SerializeField] private int unplacedTokensP2 = 9;
    [SerializeField] private int usableTokensP1 = 9;
    [SerializeField] private int usableTokensP2 = 9;

    [SerializeField] private KeyCode exitKey;

    private const int lowestTokenAmount = 2;

    public int GetUnplacedTokensP1()
    {
        return unplacedTokensP1;
    }

    public int GetUnplacedTokensP2()
    {
        return unplacedTokensP2;
    }

    public int GetUsableTokensP1()
    {
        return usableTokensP1;
    }

    public int GetUsableTokensP2()
    {
        return usableTokensP2;
    }

    [SerializeField] private GameManager_StageControl stageControl;
    [SerializeField] private GameManager_TurnControl turnControl;
    [SerializeField] private Board board;
    [SerializeField] private GameObject player1WinText;
    [SerializeField] private GameObject player2WinText;

    private bool gameOver = false;

    private bool canRemoveToken = false;

    private void Update()
    {
        if (Input.GetKeyDown(exitKey))
        {
            Application.Quit();
        }
    }

    public void ClickNode(Node nodeRef)
    {
        if (!gameOver)
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
                            nodeRef.SetPlayer1();


                            int travReturnNo = board.Check3P1();
                            if (travReturnNo > -1)
                            {
                                canRemoveToken = true;
                            }
                            Debug.Log("Traversal Return: " + travReturnNo.ToString());
                            //board traverses to check if any row3's are found for this player and returns a valid one
                            if (!canRemoveToken)
                            {
                                turnControl.SwitchTurns();
                            }
                        }
                        else if ((turnControl.GetTurn() == 1) && (unplacedTokensP2 > 0))
                        {
                            unplacedTokensP2--;
                            nodeRef.SetPlayer2();


                            int travReturnNo = board.Check3P2();
                            if (travReturnNo > -1)
                            {
                                canRemoveToken = true;
                            }
                            Debug.Log("Traversal Return: " + travReturnNo.ToString());
                            //board traverses to check if any row3's are found for this player and returns a valid one
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
                            nodeRef.SetNoPlayer();
                            canRemoveToken = false;
                            usableTokensP2--;
                            turnControl.SwitchTurns();
                        }
                    }
                    else if (turnControl.GetTurn() == 1)
                    {
                        if (nodeRef.playerSet == PLAYER.PLAYER1)
                        {
                            nodeRef.SetNoPlayer();
                            canRemoveToken = false;
                            usableTokensP1--;
                            turnControl.SwitchTurns();
                        }
                    }
                }
                if ((unplacedTokensP1 < 1) && (unplacedTokensP2 < 1))
                {
                    stageControl.SwitchStage();
                }
            }
            else if (stageControl.GetStage() == 2)
            {
                //move tokens to adjacent open spaces using NWES checking
                if (!canRemoveToken) //move tokens to adjacent open spaces
                {
                    if (nodeRef.playerSet == PLAYER.NOPLAYER)
                    {
                        if (turnControl.GetTurn() == 0)
                        {
                            if ((nodeRef.N != null) && (nodeRef.N.playerSet == PLAYER.PLAYER1))
                            {
                                if (nodeRef.N.playerSet == PLAYER.PLAYER1)
                                {
                                    nodeRef.N.SetNoPlayer();
                                    nodeRef.SetPlayer1();

                                    int travReturnNo = board.Check3P1();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.S != null) && (nodeRef.S.playerSet == PLAYER.PLAYER1))
                            {
                                if (nodeRef.S.playerSet == PLAYER.PLAYER1)
                                {
                                    nodeRef.S.SetNoPlayer();
                                    nodeRef.SetPlayer1();

                                    int travReturnNo = board.Check3P1();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.W != null) && (nodeRef.W.playerSet == PLAYER.PLAYER1))
                            {
                                if (nodeRef.W.playerSet == PLAYER.PLAYER1)
                                {
                                    nodeRef.W.SetNoPlayer();
                                    nodeRef.SetPlayer1();

                                    int travReturnNo = board.Check3P1();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.E != null) && (nodeRef.E.playerSet == PLAYER.PLAYER1))
                            {
                                if (nodeRef.E.playerSet == PLAYER.PLAYER1)
                                {
                                    nodeRef.E.SetNoPlayer();
                                    nodeRef.SetPlayer1();

                                    int travReturnNo = board.Check3P1();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                        }
                        else if (turnControl.GetTurn() == 1)
                        {
                            if ((nodeRef.N != null) && (nodeRef.N.playerSet == PLAYER.PLAYER2))
                            {
                                if (nodeRef.N.playerSet == PLAYER.PLAYER2)
                                {
                                    nodeRef.N.SetNoPlayer();
                                    nodeRef.SetPlayer2();

                                    int travReturnNo = board.Check3P2();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.S != null) && (nodeRef.S.playerSet == PLAYER.PLAYER2))
                            {
                                if (nodeRef.S.playerSet == PLAYER.PLAYER2)
                                {
                                    nodeRef.S.SetNoPlayer();
                                    nodeRef.SetPlayer2();

                                    int travReturnNo = board.Check3P2();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.W != null) && (nodeRef.W.playerSet == PLAYER.PLAYER2))
                            {
                                if (nodeRef.W.playerSet == PLAYER.PLAYER2)
                                {
                                    nodeRef.W.SetNoPlayer();
                                    nodeRef.SetPlayer2();

                                    int travReturnNo = board.Check3P2();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
                            }
                            else if ((nodeRef.E != null) && (nodeRef.E.playerSet == PLAYER.PLAYER2))
                            {
                                if (nodeRef.E.playerSet == PLAYER.PLAYER2)
                                {
                                    nodeRef.E.SetNoPlayer();
                                    nodeRef.SetPlayer2();

                                    int travReturnNo = board.Check3P2();
                                    if (travReturnNo > -1)
                                    {
                                        canRemoveToken = true;
                                    }
                                    Debug.Log("Traversal Return: " + travReturnNo.ToString());
                                    //board traverses to check if any row3's are found for this player and returns a valid one
                                    if (!canRemoveToken)
                                    {
                                        turnControl.SwitchTurns();
                                    }
                                }
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
                            nodeRef.SetNoPlayer();
                            canRemoveToken = false;
                            usableTokensP2--;
                            turnControl.SwitchTurns();
                        }
                    }
                    else if (turnControl.GetTurn() == 1)
                    {
                        if (nodeRef.playerSet == PLAYER.PLAYER1)
                        {
                            nodeRef.SetNoPlayer();
                            canRemoveToken = false;
                            usableTokensP1--;
                            turnControl.SwitchTurns();
                        }
                    }
                }
                if (usableTokensP1 < lowestTokenAmount)
                {
                    player1WinText.SetActive(true);
                    gameOver = true;
                }
                else if (usableTokensP2 < lowestTokenAmount)
                {
                    player2WinText.SetActive(true);
                    gameOver = true;
                }
            }
        }
    }
}
