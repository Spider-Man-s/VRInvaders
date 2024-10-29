using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToSafeSpot : MonoBehaviour
{
    public Transform safeSpot;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
        }
    }

    void TeleportPlayer(Transform playerTransform)
    {
        if (safeSpot != null)
        {
            playerTransform.position = safeSpot.position;
        }
    }
}

