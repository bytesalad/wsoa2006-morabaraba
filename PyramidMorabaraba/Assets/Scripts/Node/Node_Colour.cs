using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Colour : MonoBehaviour
{
    [SerializeField] private Color player1Colour;

    [SerializeField] private Color player2Colour;

    [SerializeField] private Color noPlayerColour; //is not occupied by player nodes

    [SerializeField] private Color highlightedColor;

    public void Highlight()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = highlightedColor;
    }

    public void SetPlayer1()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = player1Colour;
    }

    public void SetPlayer2()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = player2Colour;
    }

    public void SetNoPlayer()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = noPlayerColour;
    }
}
