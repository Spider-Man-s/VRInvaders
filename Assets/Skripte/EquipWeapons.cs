using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BNG
{

    public class EquipWeapons : MonoBehaviour
    {
        public PlayerUIManager skripta;

        public Grabber grabberLeft;
        public Grabber grabberRight;
        public Grabbable ARL;
        public Grabbable ARR;
        public Grabbable PistolL;
        public Grabbable PistolR;
        public Grabbable RevolverL;
        public Grabbable RevolverR;
        public Grabbable ShotgunL;
        public Grabbable ShotgunR;

        public Transform spawnPointL;
        public Transform spawnPointR;

        [SerializeField] private float timerDuration = 180f;
        public void EquipWeapon()
        {
            if (grabberLeft.HeldGrabbable != null)
            {
                grabberLeft.TryRelease();
            }
            if (grabberRight.HeldGrabbable != null)
            {
                grabberRight.TryRelease();
            }


            if (GameSettings.ChosenWeapon == GameSettings.WeaponType.Rifle)
            {
                Grabbable spawnedWeaponL = Instantiate(ARL, spawnPointL.position, spawnPointL.rotation);
                Grabbable spawnedWeaponR = Instantiate(ARR, spawnPointR.position, spawnPointR.rotation);


                grabberLeft.GrabGrabbable(spawnedWeaponL);
                grabberRight.GrabGrabbable(spawnedWeaponR);

                StartCoroutine(skripta.TimerCoroutine(timerDuration));
            }
            else if (GameSettings.ChosenWeapon == GameSettings.WeaponType.Revolver)
            {
                Grabbable spawnedWeaponL = Instantiate(RevolverL, spawnPointL.position, spawnPointL.rotation);
                Grabbable spawnedWeaponR = Instantiate(RevolverR, spawnPointR.position, spawnPointR.rotation);

                grabberLeft.GrabGrabbable(spawnedWeaponL);
                grabberRight.GrabGrabbable(spawnedWeaponR);

                StartCoroutine(skripta.TimerCoroutine(timerDuration));
            }
            else if (GameSettings.ChosenWeapon == GameSettings.WeaponType.Shotgun)
            {
                Grabbable spawnedWeaponL = Instantiate(ShotgunL, spawnPointL.position, spawnPointL.rotation);
                Grabbable spawnedWeaponR = Instantiate(ShotgunR, spawnPointR.position, spawnPointR.rotation);

                grabberLeft.GrabGrabbable(spawnedWeaponL);
                grabberRight.GrabGrabbable(spawnedWeaponR);

                StartCoroutine(skripta.TimerCoroutine(timerDuration));
            }
            else if (GameSettings.ChosenWeapon == GameSettings.WeaponType.Pistol)
            {
                Grabbable spawnedWeaponL = Instantiate(PistolL, spawnPointL.position, spawnPointL.rotation);
                Grabbable spawnedWeaponR = Instantiate(PistolR, spawnPointR.position, spawnPointR.rotation);

                grabberLeft.GrabGrabbable(spawnedWeaponL);
                grabberRight.GrabGrabbable(spawnedWeaponR);
                StartCoroutine(skripta.TimerCoroutine(timerDuration));
            }
        }


    }
}