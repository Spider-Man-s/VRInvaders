using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnTrigger : MonoBehaviour
{ public List<GameObject> objectsToHide = new List<GameObject>();

    void HideItObject(GameObject obj)
    {
        if (obj != null)
        {
            obj.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            List<GameObject> objectsToHideCopy = new List<GameObject>(objectsToHide);

            foreach (GameObject obj in objectsToHideCopy)
            {
                objectsToHide.Remove(obj);
                HideItObject(obj);
            }
        }
    }
}
