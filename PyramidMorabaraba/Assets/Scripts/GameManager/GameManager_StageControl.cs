using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_StageControl : MonoBehaviour
{
    [SerializeField] private int stage;
    [SerializeField] private int numStages;
    //1 = stage 1
    //2 = stage 2

    public void SwitchStage()
    {
        if (stage < numStages)
        {
            stage++;
        }
        else
        {
            stage = 1;
        }
    }

    public int GetStage()
    {
        return stage;
    }
}
