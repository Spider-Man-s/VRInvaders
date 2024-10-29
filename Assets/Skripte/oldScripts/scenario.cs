using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenario : MonoBehaviour
{


    public void scene1()
    {
        GlobalMemory.scenario = 1;
    }

    // Update is called once per frame
    public void scene2()
    {
        GlobalMemory.scenario = 2;
    }
}
