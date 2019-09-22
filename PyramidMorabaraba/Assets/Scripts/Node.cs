using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum PLAYER { PLAYER1 = 0, PLAYER2 = 1, NOPLAYER = 2};

public class Node : MonoBehaviour
{
    public bool cnr; // is corner node
    public Node N, S, W, E; // north, south, east and west connections to other nodes
    PLAYER playerSet; // occupied by which player? or no player.
}
