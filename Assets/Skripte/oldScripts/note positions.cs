using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePositions : MonoBehaviour
{
    public static List<Vector3> objectPositions = new List<Vector3>();
    public static List<Quaternion> objectRotations = new List<Quaternion>();

    public GameObject[] objectsToTrack;

    public GameObject kill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SaveObjectTransforms();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(kill);
        }
    }

    private void SaveObjectTransforms()
    {
        objectPositions.Clear();
        objectRotations.Clear();

        foreach (GameObject obj in objectsToTrack)
        {
            if (obj != null)
            {
                objectPositions.Add(obj.transform.position);
                objectRotations.Add(obj.transform.rotation);
            }
        }
    }
}
