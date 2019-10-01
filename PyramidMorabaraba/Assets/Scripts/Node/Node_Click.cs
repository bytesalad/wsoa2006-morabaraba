using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Click : MonoBehaviour
{
    [SerializeField] private Player_Behaviour playerBehaviour;
    private void OnMouseDown()
    {
        playerBehaviour.ClickNode(gameObject.GetComponent<Node>());
    }
}