using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAndOut : MonoBehaviour
{
    public List<GameObject> objectsToToggle = new List<GameObject>();

    public void ShowObjects()
    {
        foreach (GameObject obj in objectsToToggle)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
            else
            {
                Debug.LogError("Object doesn't exist");
            }
        }
    }

    public void HideObjects()
    {
        foreach (GameObject obj in objectsToToggle)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
            else
            {
                Debug.LogError("Object doesn't exist");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowObjects();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HideObjects();
        }
    }
}
