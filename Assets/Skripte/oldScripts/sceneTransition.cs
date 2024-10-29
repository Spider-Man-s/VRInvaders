using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneTransition : MonoBehaviour
{

    void OnEnable()
    {
        if (GlobalMemory.scenario == 1)
        {
            SceneManager.LoadScene("Demo", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("Demo 1", LoadSceneMode.Single);
        }
    }

}


