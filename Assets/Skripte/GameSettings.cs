
using UnityEngine;

public static class GameSettings
{

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public static Difficulty currentDifficulty = Difficulty.Easy;

    public static string Username = "";
    public static int Score = 0;
}
