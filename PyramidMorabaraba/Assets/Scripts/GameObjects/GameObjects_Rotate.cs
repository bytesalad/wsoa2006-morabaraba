using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects_Rotate : MonoBehaviour
{
    [SerializeField] private KeyCode rotateLeft;
    [SerializeField] private KeyCode rotateRight;

    [SerializeField] private Vector3 rotationVector;

    private void Update()
    {
        if (Input.GetKey(rotateLeft))
        {
            transform.Rotate(-1 * rotationVector * Time.deltaTime);
        }
        if (Input.GetKey(rotateRight))
        {
            transform.Rotate(rotationVector * Time.deltaTime);
        }
    }
}
