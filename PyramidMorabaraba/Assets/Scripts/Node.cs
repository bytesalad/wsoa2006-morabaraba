using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PLAYER { PLAYER1 = 0, PLAYER2 = 1, NOPLAYER = 2 };

public class Node : MonoBehaviour
{
    public bool cnr; // is corner node
    public Node N, S, W, E; // north, south, east and west connections to other nodes
    public PLAYER playerSet; // occupied by which player? or no player.
    public int level;
}
