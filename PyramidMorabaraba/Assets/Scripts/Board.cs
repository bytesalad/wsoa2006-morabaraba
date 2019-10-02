using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class implementing a 3 x 3 Morabaraba board ADT. Makes use of Node objects.
/// </summary>
public class Board : MonoBehaviour
{
    [SerializeField] private Node head;
    //first node is pointed to here.
    private const int numberChecks = 20;

    private bool[,] player1row3array = new bool[numberChecks + 1,2];
    private bool[,] player2row3array = new bool[numberChecks + 1,2];

    //first coordinate: location of a row3
    //second coordinate: has it been changed and how many times.

    //implement traversal algorithms
    //Check3Pn checks each player to see if there are any new rows of 3 as bounded by the rules of the game
    //first check for any row 3's. Then analyse to see whether that row of 3 has been encountered before.

    //RULES OF THE ALGORITHM:
    //Go through each 23 possibilities of having a row 3 and for each:
    //1.) Check if there is a row 3. If there is not, change the first index to a 0 and the second to zero
    //2.) If there is a row 3, change the first index value to a 1 and increment the stageNumber
    //3.) The stageNumber may not go over 4. Only four turns need to be checked for a certain row3.
    public int Check3P1()
    {
        Node temp;
        temp = head;
        int row3number = 0;//first index of arraý


        //debug by highlighting every node traversed.
        //first node is always gonna be a corner node so no checking needed.

        ///////////////////////////////////////////
        // 1 //
        ///////////////////////////////////////////
        //MOVE WEST
        while (row3number < numberChecks) //there are 20 possibilities that need to be checked.
        {
            //Same W,N,E,N,W,W,S,S algorithm every time
            // W //
            temp = temp.W;
            temp.GetComponent<Node_Colour>().Highlight();
            if ((temp.W != null) && (temp.E != null))
            {
                if ((temp.W.playerSet == PLAYER.PLAYER1) && (temp.E.playerSet == PLAYER.PLAYER1))
                {
                    player1row3array[row3number, 0] = true; // a row 3 has been found.
                    if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                    {
                        player1row3array[row3number, 1] = true;
                        return row3number;
                    }
                }
                else
                {
                    player1row3array[row3number, 0] = false;
                    player1row3array[row3number, 1] = false;
                }
            }

            // N //
            temp = temp.N;
            temp.GetComponent<Node_Colour>().Highlight();
            row3number++;
            if ((temp.N != null) && (temp.S != null))
            {
                if ((temp.N.playerSet == PLAYER.PLAYER1) && (temp.S.playerSet == PLAYER.PLAYER1))
                {
                    player1row3array[row3number, 0] = true; // a row 3 has been found.
                    if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                    {
                        player1row3array[row3number, 1] = true;
                        return row3number;
                    }
                }
                else
                {
                    player1row3array[row3number, 0] = false;
                    player1row3array[row3number, 1] = false;
                }
            }
            row3number++;
            if ((temp.W != null) && (temp.E != null))
            {
                if ((temp.W.playerSet == PLAYER.PLAYER1) && (temp.E.playerSet == PLAYER.PLAYER1))
                {
                    player1row3array[row3number, 0] = true; // a row 3 has been found.
                    if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                    {
                        player1row3array[row3number, 1] = true;
                        return row3number;
                    }
                }
                else
                {
                    player1row3array[row3number, 0] = false;
                    player1row3array[row3number, 1] = false;
                }
            }

            if (row3number < 6) // East check only needs to be done once in the beginning
            {
                // E //
                temp = temp.E;
                temp.GetComponent<Node_Colour>().Highlight();
                row3number++;
                if ((temp.N != null) && (temp.S != null))
                {
                    if ((temp.N.playerSet == PLAYER.PLAYER1) && (temp.S.playerSet == PLAYER.PLAYER1))
                    {
                        player1row3array[row3number, 0] = true; // a row 3 has been found.
                        if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                        {
                            player1row3array[row3number, 1] = true;
                            return row3number;
                        }
                    }
                    else
                    {
                        player1row3array[row3number, 0] = false;
                        player1row3array[row3number, 1] = false;
                    }
                }
            }

            // N //
            temp = temp.N;
            temp.GetComponent<Node_Colour>().Highlight();
            // nothing to check

            // W //
            temp = temp.W;
            temp.GetComponent<Node_Colour>().Highlight();
            row3number++;
            if ((temp.W != null) && (temp.E != null))
            {
                if ((temp.W.playerSet == PLAYER.PLAYER1) && (temp.E.playerSet == PLAYER.PLAYER1))
                {
                    player1row3array[row3number, 0] = true; // a row 3 has been found.
                    if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                    {
                        player1row3array[row3number, 1] = true;
                        return row3number;
                    }
                }
                else
                {
                    player1row3array[row3number, 0] = false;
                    player1row3array[row3number, 1] = false;
                }
            }

            // W //
            temp = temp.W;
            temp.GetComponent<Node_Colour>().Highlight();
            //nothing to check

            if (row3number < numberChecks)
            {
                // S //
                temp = temp.S;
                temp.GetComponent<Node_Colour>().Highlight();
                row3number++;
                if ((temp.N != null) && (temp.S != null))
                {
                    if ((temp.N.playerSet == PLAYER.PLAYER1) && (temp.S.playerSet == PLAYER.PLAYER1))
                    {
                        player1row3array[row3number, 0] = true; // a row 3 has been found.
                        if (!player1row3array[row3number, 1]) // if this row 3 has not been checked already
                        {
                            player1row3array[row3number, 1] = true;
                            return row3number;
                        }
                    }
                    else
                    {
                        player1row3array[row3number, 0] = false;
                        player1row3array[row3number, 1] = false;
                    }
                }
            }

            // S //
            temp = temp.S;
            temp.GetComponent<Node_Colour>().Highlight();
            row3number++;
        }

        return -1;
    }

    public int Check3P2()
    {
        return -1;
    }
}
