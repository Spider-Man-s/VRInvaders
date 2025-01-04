using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreForKill : MonoBehaviour
{


    public void addPoints()
    {


        if (GameSettings.currentDifficulty == GameSettings.Difficulty.Easy)
        {
            GameSettings.Score += 25;
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Medium)
        {
            GameSettings.Score += 50;
        }
        else if (GameSettings.currentDifficulty == GameSettings.Difficulty.Hard)
        {
            GameSettings.Score += 100;
        }
    }

}
