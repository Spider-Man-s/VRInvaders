using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject objectToShow;
    public void ShowObject()
    {
        if (objectToShow != null)
        {
            objectToShow.SetActive(true);
        }
        else
        {
            Debug.LogError("Object doesn't exist");
        }
    }

  public void OnTriggerEnter( Collider other){
    if (other.CompareTag("Player")){
        ShowObject();
    }
  }
    
}
