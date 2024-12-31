using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDiff : MonoBehaviour
{
    public void SetEasy()
    {
        GameSettings.currentDifficulty = GameSettings.Difficulty.Easy;

    }

    public void SetMedium()
    {
        GameSettings.currentDifficulty = GameSettings.Difficulty.Medium;

    }

    public void SetHard()
    {
        GameSettings.currentDifficulty = GameSettings.Difficulty.Hard;

    }


}

