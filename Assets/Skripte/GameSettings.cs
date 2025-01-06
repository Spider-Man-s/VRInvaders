
using UnityEngine;

public static class GameSettings
{

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public enum WeaponType
    {
        Pistol,
        Revolver,
        Shotgun,
        Rifle
    }

    public static Difficulty currentDifficulty = Difficulty.Easy;

    public static string Username = "Default";
    public static int Score = 0;

    public static bool HasWeapon = false;

    public static WeaponType ChosenWeapon = WeaponType.Pistol;

    public static bool PlayerDeath = false;
}
