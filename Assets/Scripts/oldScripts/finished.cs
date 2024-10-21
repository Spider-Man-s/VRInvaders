using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finished : MonoBehaviour
{
    public GameObject Character;
    private Animator animator;

    public void stop()
    {
        animator = Character.GetComponent<Animator>();
        animator.SetTrigger("finished");

    }
}
