using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Colour : MonoBehaviour
{
    [SerializeField] private Color player1Colour;

    [SerializeField] private Color player2Colour;

    [SerializeField] private Color noPlayerColour;

    [SerializeField] private Color highlightedColor;

    public void Highlight()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = highlightedColor;
    }
}
