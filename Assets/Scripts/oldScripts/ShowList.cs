using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowList : MonoBehaviour
{
    public List<GameObject> objectsToShow = new List<GameObject>();

    public void ShowObjects()
    {
        foreach (GameObject obj in objectsToShow)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowObjects();
        }
    }
}
