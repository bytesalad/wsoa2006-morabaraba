using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Text : MonoBehaviour
{
    [SerializeField] private Player_Behaviour playerBehaviour;

    [SerializeField] private Text player1;

    [SerializeField] private Text player2;

    private void Update()
    {
        player1.text = "PLAYER 1:" + "\n" + "Unplaced Tokens: " + playerBehaviour.GetUnplacedTokensP1().ToString() + "\n" + "Usable Tokens: "
            + playerBehaviour.GetUsableTokensP1().ToString();
        player2.text = "PLAYER 2:" + "\n" + "Unplaced Tokens: " + playerBehaviour.GetUnplacedTokensP2().ToString() + "\n" + "Usable Tokens: "
            + playerBehaviour.GetUsableTokensP2().ToString();
    }
}
