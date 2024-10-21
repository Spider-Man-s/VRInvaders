using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIt : MonoBehaviour
{
    public List<GameObject> objectsToDestroy = new List<GameObject>();

    void Awake()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            DestroyObject(obj);
        }
    }

    public void DestroyObject(GameObject obj)
    {
        objectsToDestroy.Remove(obj);
        Destroy(obj);
    }
}
