using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Click : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponent<Node_Colour>().Highlight();
    }
}