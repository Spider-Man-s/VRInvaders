using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class ResetTools : MonoBehaviour
{
    public GameObject[] objectsToReset;

    public void SetPositionsForNamedObjects()
    {
        if (objectsToReset != null)
        {
            for (int i = 0; i < objectsToReset.Length; i++)
            {
                GameObject obj = objectsToReset[i];
                if (obj != null && i < NotePositions.objectPositions.Count)
                {
                    obj.transform.position = NotePositions.objectPositions[i];
                    obj.transform.rotation = NotePositions.objectRotations[i];

                    Rigidbody rb = obj.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.velocity = Vector3.zero;
                        rb.angularVelocity = Vector3.zero;
                    }
                }
            }
        }
    }
}