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

    public void SetPistol()
    {
        GameSettings.ChosenWeapon = GameSettings.WeaponType.Pistol;

    }

    public void SetRevolver()
    {
        GameSettings.ChosenWeapon = GameSettings.WeaponType.Revolver;

    }

    public void SetShotgun()
    {
        GameSettings.ChosenWeapon = GameSettings.WeaponType.Shotgun;

    }
    public void SetRifle()
    {
        GameSettings.ChosenWeapon = GameSettings.WeaponType.Rifle;

    }

}

